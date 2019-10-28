using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skor1 : MonoBehaviour {
    public int a;
	// Use this for initialization
	void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
      
        GameObject.FindGameObjectWithTag("skor1").GetComponent<Text>().text =
          (int.Parse(GameObject.FindGameObjectWithTag("skor1").GetComponent<Text>().text) + ObjectTab.skor).ToString();
              ObjectTab.skor = 0;
    }
}
