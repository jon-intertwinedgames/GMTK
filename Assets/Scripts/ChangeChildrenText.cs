using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeChildrenText : MonoBehaviour
{
    private void Start()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().text = (i + 1).ToString();
        }
    }
}
