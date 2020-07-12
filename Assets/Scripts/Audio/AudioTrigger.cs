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
    private bool isCutScene = false;

    [SerializeField]
    private float delayBetweenClips = 0;

    [SerializeField]
    private AudioClip[] audioClips = null;

    //[SerializeField]
    //private AudioOptions audioOption;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == tagToSense)
        {
            LevelManager.instance.InCutscene = isCutScene;
            AudioManager.instance.StartCoroutine(AudioManager.PlayAudioClipsSynchronously(audioClips, delayBetweenClips));

            if( onlyTriggerOnce ) {
                Destroy(gameObject);
            }
        }
    }
}
