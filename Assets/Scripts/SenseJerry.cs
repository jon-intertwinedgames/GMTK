using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenseJerry : MonoBehaviour
{
    CircleCollider2D sensor;

    private void Awake()
    {
        sensor = GetComponent<CircleCollider2D>();
    }
    private void Update()
    {
        if (sensor.IsTouchingLayers())
        {
            Medusa.instance.speed = Medusa.instance.DefaultSpeed;
        }
        else
        {
            Medusa.instance.speed = Medusa.instance.FastSpeed;
        }

        transform.position = Medusa.instance.transform.position;
    }
}
