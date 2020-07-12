using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVScreen : MonoBehaviour
{
    public static TVScreen instance;

    [SerializeField]
    private GameObject deathImage = null;

    private void Awake()
    {
        if( instance == null ) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    public void ShowDeathImage() {
        deathImage.SetActive(true);
    }
}
