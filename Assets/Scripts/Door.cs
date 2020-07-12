using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private Transform destinationWayPoint = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player") {
            GameObject cameraJerryIsLeaving = transform.parent.GetChild(0).gameObject;
            
            if(cameraJerryIsLeaving.tag != "Camera") {
                print("This gameObject isn't a camera. This is an error!");
            } else {
                cameraJerryIsLeaving.GetComponent<Cinemachine.CinemachineVirtualCamera>().Follow = null;
            }


            collision.transform.position = destinationWayPoint.position;
            string nextRoom = destinationWayPoint.parent.parent.name;

            LevelManager.instance.currentRoomNum = int.Parse(nextRoom.Substring(nextRoom.Length - 1));
            Jerry.instance.SetToStopSpeed();

            if (nextRoom == CameraManager.instance.activeCamera.transform.parent.name) {
                CameraManager.instance.activeCamera.GetComponent<Cinemachine.CinemachineVirtualCamera>().Follow = Jerry.instance.transform;
            }
        }
    }
}
