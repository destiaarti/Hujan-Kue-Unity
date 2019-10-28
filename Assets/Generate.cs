using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {

    // Use this for initialization
    public GameObject prefab1;

    public GameObject prefab2;

    public GameObject prefab3;

    public int platform;

    // Use this for initialization
    void Start()

    {
        InvokeRepeating("CreateObstacle", 1f, 1.5f);    //generate
    }

    void CreateObstacle()
    {
        platform = Random.Range(1, 7);             //radom number generator b/w 1 and 7
        float randomY = Random.Range(-5f, 5f);      // appear b/w -5 and 5 in y-axis
        float rightScreenBound = 10;                // spawn this much right of the screen

        switch (platform)
        {
            case 1:
                Instantiate(prefab1, new Vector3(rightScreenBound, randomY, 0), Quaternion.identity);
                break;
            case 2:
                Instantiate(prefab2, new Vector3(rightScreenBound, randomY, 0), Quaternion.identity);
                break;
            case 3:
                Instantiate(prefab3, new Vector3(rightScreenBound, randomY, 0), Quaternion.identity);
                break;
              }


    }
}
