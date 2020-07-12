using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvacMap : MonoBehaviour
{
    public void ToggleMap()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
