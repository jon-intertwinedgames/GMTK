using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public int currentRoomNum = 1;

    private void Awake()
    {
        if( instance == null ) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }
}
