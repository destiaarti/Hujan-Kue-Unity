using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour {
	
	public int levelNr;
	
	
	
	void Start ()
	{
		GetComponent<Text>().text += levelNr;
         }
	
	
	
	void OnMouseUp ()
	{
		ApplicationModel.currentLevel = levelNr;
		Application.LoadLevel ("Scene2");
	}

	
}
