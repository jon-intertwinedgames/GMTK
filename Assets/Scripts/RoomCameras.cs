using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCameras : MonoBehaviour
{
    void Start()
    {
        GetComponent<ExecuteOnEnable>().AddMethodsToExecute(InitializeCamera);
    }

    private void InitializeCamera()
    {
        TVText.instance.ChangeCameraLabel(transform.parent.GetSiblingIndex() + 1);
    }
}
