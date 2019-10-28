using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cabe : MonoBehaviour {
    public static bool a;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public void Cabeimut()
    {


        GameObject.FindGameObjectWithTag("skor").GetComponent<Text>().text =
        (int.Parse(GameObject.FindGameObjectWithTag("skor").GetComponent<Text>().text) * 2).ToString();
        ObjectTab.skor = ObjectTab.skor * 2;
        GameObject.FindGameObjectWithTag("cabe").GetComponent<Text>().text =
   (int.Parse(GameObject.FindGameObjectWithTag("cabe").GetComponent<Text>().text) - 1).ToString();



    }
    public void Cabenakal()
    {
       if (a)

        GameObject.FindGameObjectWithTag("cabe").GetComponent<Text>().text =
        (int.Parse(GameObject.FindGameObjectWithTag("cabe").GetComponent<Text>().text) -1).ToString();
       
    }
}
