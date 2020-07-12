using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllCutscenes : MonoBehaviour
{
    public static AllCutscenes instance;

    private void Awake()
    {
        if( instance == null ) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    public IEnumerator IntroCutscene() {
        print("Cutscene");
        yield return null;
    }
}
