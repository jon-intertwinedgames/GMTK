using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    [SerializeField]
    private string tagToSense = "";

    [SerializeField]
    private bool onlyTriggerOnce = false;

    [SerializeField]
    private SFX sfx;

    [SerializeField]
    private AudioOptions audioOption;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == tagToSense)
        {
            AudioManager.PlaySFX(audioOption.Volume, audioOption.Delay, audioOption.WillLoop, SFX.RandomSound);

            if( onlyTriggerOnce ) {
                Destroy(this);
            }
        }
    }
}
