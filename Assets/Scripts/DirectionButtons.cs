using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionButtons : MonoBehaviour
{
    public void CallOutDirection( Direction direction ) {
        Jerry.instance.direction = direction;
    }
}
