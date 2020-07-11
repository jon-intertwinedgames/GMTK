using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;

    public GameObject[] allCameras;
    public GameObject activeCamera;

    private void Awake()
    {
        if(instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        allCameras = GameObject.FindGameObjectsWithTag("Camera");

        foreach(GameObject camera in allCameras) {
            if ( camera != activeCamera ) {
                camera.SetActive(false);
            }
        }
    }
}
