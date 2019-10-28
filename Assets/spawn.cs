using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawn : MonoBehaviour {
    public GameObject kue1aPrefab;
	public Sprite[] kue1aSprites;
  


    public void MakeRandomAnimal()
    {
                   int arrayIdx = Random.Range(0, kue1aSprites.Length);
            Sprite kue1aSprite = kue1aSprites[arrayIdx];
            string kue1a = kue1aSprite.name;
            GameObject newKue1a = Instantiate(kue1aPrefab);
            newKue1a.name = kue1a;
            newKue1a.GetComponent<kue1a>().kue1aName = kue1a;
            newKue1a.GetComponent<SpriteRenderer>().sprite = kue1aSprite;
            
        }
               
    
    
    public void RemoveArray(int kue1aSprite)

    { 
       

    }
 } 

