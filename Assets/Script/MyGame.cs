using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MyGame : MonoBehaviour {
	
	
	
	void Start ()
	{
		int skip = pindah1.skip;
		loadLevelData (skip);
        int skip1 = pindah1.skip1;
        loadLevelData1(skip1);
        int skip2 = pindah1.skip2;
        loadLevelData1(skip2);
    }
	
	

	void loadLevelData (int skip)
	{
		// load level data here
		
		GameObject.Find("est").GetComponent<Text>().text += skip;
	}

    void loadLevelData1(int skip1)
    {
        // load level data here

        GameObject.Find("cabet").GetComponent<Text>().text += skip1;
    }

    void loadLevelData2(int skip2)
    {
        // load level data here


    }


}
