﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillJerry : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Jerry"))
        {
            Jerry.instance.Dies();
        }
    }
}
