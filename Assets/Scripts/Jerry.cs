using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jerry : MonoBehaviour
{
    public static Jerry instance;
    private Rigidbody2D rb;

    [SerializeField]
    private float normalSpeed = 5, runningSpeed = 8;

    public Direction direction = Direction.Up;

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
                        this.direction = Direction.Left;
                        break;
                    case Direction.Left:
                        this.direction = Direction.Down;
                        break;
                    case Direction.Down:
                        this.direction = Direction.Right;
                        break;
                    default:
                        this.direction = Direction.Up;
                        break;
                }
                break;

            case "r":
                switch (this.direction)
                {
                    case Direction.Up:
                        this.direction = Direction.Right;
                        break;
                    case Direction.Left:
                        this.direction = Direction.Up;
                        break;
                    case Direction.Down:
                        this.direction = Direction.Left;
                        break;
                    default:
                        this.direction = Direction.Down;
                        break;
                }
                break;

            case "d":
                switch (this.direction)
                {
                    case Direction.Up:
                        this.direction = Direction.Down;
                        break;
                    case Direction.Left:
                        this.direction = Direction.Right;
                        break;
                    case Direction.Down:
                        this.direction = Direction.Up;
                        break;
                    default:
                        this.direction = Direction.Left;
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
}
