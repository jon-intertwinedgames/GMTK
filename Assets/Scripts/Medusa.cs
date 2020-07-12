﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medusa : MonoBehaviour
{
    [SerializeField]
    private float speed = 3;

    [SerializeField]
    private Transform jerry_trans;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 direction = jerry_trans.position - transform.position;

        direction = direction.normalized * speed;

        rb.velocity = direction;
    }
}
