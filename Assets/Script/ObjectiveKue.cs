using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveKue : MonoBehaviour
{

    public int IDKueSaatIni;
    public Sprite[] SpriteKue;
    public Sprite[] SpriteKue1;
    public Sprite[] SpriteKue2;
    public Sprite[] SpriteKue3;
    public Sprite[] SpriteKue4;
    public Sprite[] SpriteKue5;
    public Sprite[] SpriteKue6;
    public Sprite[] SpriteKue7;
    public Sprite[] SpriteKue8;
    public Sprite[] SpriteKue9;
    public Sprite[] SpriteKue10;
    public Sprite[] SpriteKue11;
    public Sprite[] SpriteKue12;
    public Sprite[] SpriteKue13;
    public Sprite[] SpriteKue14;
    public Sprite[] SpriteKue15;
    public Sprite[] SpriteKue16;
    public Sprite[] SpriteKue17;
    public Sprite[] SpriteKue18;
    public Sprite[] SpriteKue19;
    public bool pakaiWaktu;
    public float timeForChangeSprite;

    private float increasingTime;
	// Use this for initialization
	void Start () {
        randomIDKue();
        gantiSpriteKue();
       
    }
	
	// Update is called once per frame
	void Update () {
       
       
        changeByTime();
	}

    public void randomIDKue()
    {
        if (pindah1.su == true)
        {
            IDKueSaatIni = UnityEngine.Random.Range(0, SpriteKue1.Length);
        }
       else if (pindah1.su1 == true)
        {
            IDKueSaatIni = UnityEngine.Random.Range(0, SpriteKue1.Length);
        }
        else if (pindah1.su2 == true)
        {
            IDKueSaatIni = UnityEngine.Random.Range(0, SpriteKue1.Length);
        }
        else if (pindah1.su3 == true)
        {
            IDKueSaatIni = UnityEngine.Random.Range(0, SpriteKue1.Length);
        }
        else if (pindah1.su4 == true)
        {
            IDKueSaatIni = UnityEngine.Random.Range(0, SpriteKue1.Length);
        }
        else if (pindah1.su5 == true)
        {
            IDKueSaatIni = UnityEngine.Random.Range(0, SpriteKue1.Length);
        }
        else if (pindah1.su6 == true)
        {
            IDKueSaatIni = UnityEngine.Random.Range(0, SpriteKue1.Length);
        }
        else if (pindah1.su7 == true)
        {
            IDKueSaatIni = UnityEngine.Random.Range(0, SpriteKue1.Length);
        }
        else
        {
            IDKueSaatIni = UnityEngine.Random.Range(0, SpriteKue.Length);
        }
       

    }

    public void gantiSpriteKue()
    {
        if (pindah1.su == true)
        {

            GetComponent<SpriteRenderer>().sprite = SpriteKue1[IDKueSaatIni];
        }
        else if (pindah1.su1 == true)
        {

            GetComponent<SpriteRenderer>().sprite = SpriteKue2[IDKueSaatIni];
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = SpriteKue[IDKueSaatIni];
        }
       
    }

    public void changeByTime()
    {
        if (pakaiWaktu)
        {
            increasingTime += Time.deltaTime;
            if (increasingTime >= timeForChangeSprite)
            {
                randomIDKue();
                gantiSpriteKue();
                increasingTime = 0;
            }
        }
    }
}
