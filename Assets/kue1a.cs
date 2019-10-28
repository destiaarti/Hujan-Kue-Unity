using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kue1a : MonoBehaviour {

    private Vector2 origPos;
    public string kue1aName;
    public bool returnToOrigin = false;

    void Start()
    {
      
        origPos = transform.position;
    }

    void OnMouseUp()
    {
        if (returnToOrigin)
            transform.position = origPos;

    }
}
