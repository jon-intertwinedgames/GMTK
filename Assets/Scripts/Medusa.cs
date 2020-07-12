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

    public float speed;

    [SerializeField]
    private Transform jerry_trans = null;

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
        Vector2 direction = jerry_trans.position - transform.position;

        direction = direction.normalized * speed;

        rb.velocity = direction;
    }
}
