using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balik : MonoBehaviour {

    // Use this for initialization
    void Start() {
      
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel("awal");
    }


}
