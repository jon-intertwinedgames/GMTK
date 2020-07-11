using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jerry : MonoBehaviour
{
    public static Jerry instance;
    private Rigidbody2D rb;

    [SerializeField]
    private float normalSpeed = 5, runningSpeed = 8;

    private Direction direction = Direction.Up;
    public Direction DirectionProp {
        get => direction;

        set {
            if( direction != value) {
                direction = value;

                transform.rotation = Quaternion.Euler(0, 0, (int)direction * 90);
            }
        }
    }

    void Awake()
    {
        if( instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }

        rb = GetComponent<Rigidbody2D>();
    }

    public void ChangeDirection(string direction)
    {
        switch ( direction.ToLower() ) {
            case "l":
                switch( this.direction ) {
                    case Direction.Up:
                        DirectionProp = Direction.Left;
                        break;
                    case Direction.Left:
                        DirectionProp = Direction.Down;
                        break;
                    case Direction.Down:
                        DirectionProp = Direction.Right;
                        break;
                    default:
                        DirectionProp = Direction.Up;
                        break;
                }
                break;

            case "r":
                switch (this.direction)
                {
                    case Direction.Up:
                        DirectionProp = Direction.Right;
                        break;
                    case Direction.Left:
                        DirectionProp = Direction.Up;
                        break;
                    case Direction.Down:
                        DirectionProp = Direction.Left;
                        break;
                    default:
                        DirectionProp = Direction.Down;
                        break;
                }
                break;

            case "d":
                switch (this.direction)
                {
                    case Direction.Up:
                        DirectionProp = Direction.Down;
                        break;
                    case Direction.Left:
                        DirectionProp = Direction.Right;
                        break;
                    case Direction.Down:
                        DirectionProp = Direction.Up;
                        break;
                    default:
                        DirectionProp = Direction.Left;
                        break;
                }
                break;
        }
    }

    public Vector2 GetVectorDirection() {
        switch (direction) {
            case Direction.Up:
                return Vector2.up;
            case Direction.Down:
                return Vector2.down;
            case Direction.Left:
                return Vector2.left;
            default:
                return Vector2.right;
        }
    }

    public void SetToNormalSpeed() {        
        rb.velocity = GetVectorDirection() * normalSpeed;
    }

    public void SetToRunSpeed() {
        rb.velocity = GetVectorDirection() * runningSpeed;
    }

    public void SetToStopSpeed() {
        rb.velocity = Vector2.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SetToStopSpeed();
    }
}
