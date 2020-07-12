using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject extremeDialogueOptions;

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftControl)) {
            extremeDialogueOptions.SetActive(true);
        } else {
            extremeDialogueOptions.SetActive(false);
        }
    }
}
