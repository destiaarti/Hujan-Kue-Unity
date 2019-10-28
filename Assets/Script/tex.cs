using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tex : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
              (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) + ObjectTab.koin).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
