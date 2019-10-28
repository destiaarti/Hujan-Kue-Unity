using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pindah1 : MonoBehaviour
{
    static bool a;
    public static int skip;
    public static int skip1;
    public static int skip2;
  
    public static bool su = false;
    public static bool su1 = false;
    public static bool su2 = false;
    public static bool su3 = false;
    public static bool su4 = false;
    public static bool su5 = false;
    public static bool su6 = false;
    public static bool su7 = false;
    public static bool su8 = false;
    public static bool su9 = false;
    public static bool su10 = false;
    public static bool su11 = false;
    public static bool su12 = false;
    public static bool su13 = false;
    public static bool su14 = false;
    public static bool su15 = false;
    public static bool su16 = false;
    public static bool su17 = false;
    public static bool su18 = false;
    public static bool su19 = false;
    public Image image;
    public bool isPress = false;
    public Button button;
    public Sprite moff;
    public Sprite mon;
    // Use this for initialization
    void Start()
    {
        if (su == false)
        {
            image = button.GetComponent<Image>();
            image.sprite = mon;
        }
        else
        {
            image = button.GetComponent<Image>();
            image.sprite = moff;
        }
    }
    private void Update()
    {

    }
    public void ChangeSprites()
    {
        if (ObjectTab.koin >= 1)
        {
            ObjectTab.koin -= 1;
            GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
            (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
            GameObject.FindGameObjectWithTag("skip").GetComponent<Text>().text =
          (int.Parse(GameObject.FindGameObjectWithTag("skip").GetComponent<Text>().text) + 1).ToString();
            skip = skip + 1;

        }


    }
    public void cabess()
    {
        if (ObjectTab.koin >= 1)
        {
            ObjectTab.koin -= 1;
            GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
            (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
            GameObject.FindGameObjectWithTag("skip1").GetComponent<Text>().text =
          (int.Parse(GameObject.FindGameObjectWithTag("skip1").GetComponent<Text>().text) + 1).ToString();
            skip1 = skip1 + 1;

        }

    }
    public void nyawa()
    {
        if (ObjectTab.koin >= 1)
        {
            ObjectTab.koin -= 1;
            GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
            (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
            GameObject.FindGameObjectWithTag("skip2").GetComponent<Text>().text =
          (int.Parse(GameObject.FindGameObjectWithTag("skip2").GetComponent<Text>().text) + 1).ToString();
            skip2 = skip2 + 1;

        }

    }
    public void jajan()
    {
        if (ObjectTab.koin >= 1)
        {
           
            if (su != true)
            {
                image = button.GetComponent<Image>();
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su = true;
                image = button.GetComponent<Image>();
                image.sprite = moff;
               

            }
            else if (su==true)
            {
                image = button.GetComponent<Image>();
                image.sprite = moff;
            }

        }
        else if (ObjectTab.koin >= 1 && su == true)
        {
            if (su1 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su1 = true;
            }
            else
            {
            }
        }
        else if (ObjectTab.koin >= 1 && su1 == true)
        {
            if (su2 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su2 = true;
            }
        }

        else if (ObjectTab.koin >= 1 && su2 == true)
        {
            if (su3 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su3 = true;
            }

        }

        else if (ObjectTab.koin >= 1 && su3 == true)
        {
            if (su4 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su4 = true;

            }
        }

        else if (ObjectTab.koin >= 1 && su4 == true)
        {
            if (su5 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su5 = true;
            }
        }

        else if (ObjectTab.koin >= 1 && su5 == true)
        {
            if (su6 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su6 = true;
            }
        }

        else if (ObjectTab.koin >= 1 && su6 == true)
        {
            if (su7 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su7 = true;
            }
        }

        else if (ObjectTab.koin >= 1 && su7 == true)
        {
            if (su8 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su8 = true;
            }
        }

        else if (ObjectTab.koin >= 1 && su8 == true)
        {
            if (su9 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su9 = true;
            }
        }

        else if (ObjectTab.koin >= 1 && su9 == true)
        {
            if (su10 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su10 = true;
            }
        }

        else if (ObjectTab.koin >= 1 && su10 == true)
        {
            if (su11 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su11 = true;
            }
        }

        else if (ObjectTab.koin >= 1 && su11 == true)
        {
            if (su12 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su12 = true;
            }
        }


        else if (ObjectTab.koin >= 1 && su12 == true)
        {
            if (su13 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su13 = true;
            }
        }

        else if (ObjectTab.koin >= 1 && su13 == true)
        {
            if (su14 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su14 = true;
            }
        }
        else if (ObjectTab.koin >= 1 && su14 == true)
        {
            if (su15 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su15 = true;
            }
        }
        else if (ObjectTab.koin >= 1 && su15 == true)
        {
            if (su16 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su16 = true;
            }
            else
            {

            }
        }
        else if (ObjectTab.koin >= 1 && su16 == true)
        {
            if (su17 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su17 = true;
            }
        }
        else if (ObjectTab.koin >= 1 && su17 == true)
        {
            if (su18 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su18 = true;
            }
        }
        else if (ObjectTab.koin >= 1 && su18 == true)
        {
            if (su19 != true)
            {
                ObjectTab.koin -= 1;
                GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin1").GetComponent<Text>().text) - 1).ToString();
                su19 = true;
            }
        }
        
    }
  
}
