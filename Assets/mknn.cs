using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mknn : MonoBehaviour
{
    private Vector2 origPos;
    public string mknnName;
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