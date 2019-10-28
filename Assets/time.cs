using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time : MonoBehaviour {

    // Use this for initialization
    float timeRemaining = 5.0f;

    void Update()
    {
        timeRemaining -= Time.deltaTime;
    }

    void OnGUI()
    {
        if (timeRemaining > 0)
        {
            GUI.Label(new Rect(100, 100, 200, 100),
                         "Time Remaining : " + timeRemaining);
        }
        else
        {
            GUI.Label(new Rect(100, 100, 200, 100), "Time's Up");
        }
    }

}
