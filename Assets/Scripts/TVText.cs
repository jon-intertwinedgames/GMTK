using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TVText : MonoBehaviour
{
    public static TVText instance;

    private TextMeshProUGUI cameraLabel;

    void Awake()
    {
        if(instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }

        cameraLabel = GetComponent<TextMeshProUGUI>();
    }

    public void ChangeCameraLabel(int roomNum) {
        cameraLabel.text = "Room " + roomNum;
    }
}
