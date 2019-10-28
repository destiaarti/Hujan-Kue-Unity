using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    float timeLeft = 15.0f;
    // Use this for initialization
    private Vector4 offset;

    public GameObject kue1aPrefab;
    public Sprite[] kue1aSprites;

    // Use this for initialization
    void Start() {
        

    }

    private void Update()
    {
        
        if (timeLeft > 0)

        {
            timeLeft -= Time.deltaTime;
            

    }
        else
        {
                    MakeRandomAnimal();
            Vector4 mousePos = new Vector4(Input.mousePosition.x, Input.mousePosition.y, 0);
            offset = transform.position - Camera.main.ScreenToWorldPoint(mousePos);
        }
    }
   


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
    // Update is called once per frame

}
