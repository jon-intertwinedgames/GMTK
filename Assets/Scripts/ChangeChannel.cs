using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeChannel : MonoBehaviour
{
    [SerializeField]
    [Range(0, 2)]
    private float defaultSoftZoneWidthHeight = 0.8f;
    
    public void ChangeCamera()
    {
        int siblingIndex = transform.GetSiblingIndex();
        CameraManager.instance.activeCamera.SetActive(false);        
        CameraManager.instance.activeCamera = CameraManager.instance.allCameras[siblingIndex];
        Camera.main.GetComponent<CinemachineBrain>().enabled = false;
        Camera.main.transform.position = CameraManager.instance.activeCamera.transform.position;
        Camera.main.GetComponent<CinemachineBrain>().enabled = true;

        string roomNameOfActiveCamera = CameraManager.instance.activeCamera.transform.parent.name;

        if (LevelManager.instance.currentRoomNum == int.Parse(roomNameOfActiveCamera.Substring(roomNameOfActiveCamera.Length - 1))) {
            CameraManager.instance.activeCamera.GetComponent<CinemachineVirtualCamera>().Follow = Jerry.instance.transform;
        }

        CameraManager.instance.activeCamera.SetActive(true);
    }
}
