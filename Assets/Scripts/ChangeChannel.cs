using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeChannel : MonoBehaviour
{
    public void ChangeCamera()
    {
        int siblingIndex = transform.GetSiblingIndex();
        CameraManager.instance.activeCamera.SetActive(false);        
        CameraManager.instance.activeCamera = CameraManager.instance.allCameras[siblingIndex];
        Camera.main.GetComponent<CinemachineBrain>().enabled = false;
        Camera.main.transform.position = CameraManager.instance.activeCamera.transform.position;
        Camera.main.GetComponent<CinemachineBrain>().enabled = true;
        CameraManager.instance.activeCamera.SetActive(true);
    }
}
