using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct AudioOptions
{
    [SerializeField][Range(0, 1)]
    private float volume;

    [SerializeField]
    private float delay;

    [SerializeField]
    private bool willLoop;

    public Coroutine audioCoroutine;

    public float Volume { get => volume; }
    public float Delay { get => delay; }
    public bool WillLoop { get => willLoop; }

    public AudioOptions(float volume, float delay, bool willLoop, Coroutine audioCoroutine)
    {
        this.volume = volume;
        this.delay = delay;
        this.willLoop = willLoop;
        this.audioCoroutine = audioCoroutine;
    }
}
