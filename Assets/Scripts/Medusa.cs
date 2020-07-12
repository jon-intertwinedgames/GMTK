using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medusa : MonoBehaviour
{
    public static Medusa instance;

    [SerializeField]
    private float defaultSpeed = 3, fastSpeed = 20;

    public float DefaultSpeed { get => defaultSpeed; }
    public float FastSpeed { get => fastSpeed; }

    [SerializeField]
    public float speed;

    [SerializeField]
    private Transform jerry_trans = null;

    [SerializeField]
    private bool chase = false;

    private Rigidbody2D rb;

    private void Awake()
    {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }

        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (chase)
        {
            Vector2 direction = jerry_trans.position - transform.position;

            direction = direction.normalized * speed;

            rb.velocity = direction;
        } else {
            rb.velocity = Vector2.zero;
        }
    }
}
