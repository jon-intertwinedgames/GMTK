using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteOnEnable : MonoBehaviour
{
    private event Action methodsToExecute;

    private void OnEnable()
    {        
        methodsToExecute?.Invoke();        
    }

    public void AddMethodsToExecute( params Action[] methods) {
        foreach (Action method in methods) {
            methodsToExecute += delegate { method(); };
        }
    }
}
