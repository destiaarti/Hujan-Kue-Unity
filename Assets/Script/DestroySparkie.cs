using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySparkie : MonoBehaviour
{

    private float durasiAnimasi; // durasi animasi mati habis selesai
    private float increasingTime;
	// Use this for initialization
	void Start ()
	{
	    durasiAnimasi = 0.7f;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    increasingTime += Time.deltaTime;
	    if (increasingTime >= durasiAnimasi)
	    {
	        Destroy(gameObject);
	    }
	}
}
