using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    [HideInInspector]
    public int currentRoomNum = 1;

    private bool inCutscene = false;

    public bool InCutscene { 
        get => inCutscene;
    
        set { inCutscene = value; }
    }

    [SerializeField]
    private GameObject dialogueOptions;

    private void Awake()
    {
        if( instance == null ) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        //LoadCheckpoint();
    }

    public void SaveGame() {
        PlayerPrefs.SetFloat("jerryXPos", Jerry.instance.transform.position.x);
        PlayerPrefs.SetFloat("jerryYPos", Jerry.instance.transform.position.y);
        PlayerPrefs.SetFloat("roomNum", currentRoomNum);
    }

    public void LoadCheckpoint() {
        Vector2 jerryPos;
        jerryPos.x = PlayerPrefs.GetFloat("jerryXPos");
        jerryPos.y = PlayerPrefs.GetFloat("jerryYPos");
        TVText.instance.ChangeCameraLabel(PlayerPrefs.GetInt("roomNum", 1));

        Jerry.instance.transform.position = jerryPos;
    }

    public void StartCutscene() {
        inCutscene = true;
        dialogueOptions.SetActive(false);
        Jerry.instance.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    public void EndCutscene() {
        inCutscene = false;
        dialogueOptions.SetActive(true);
    }
}
