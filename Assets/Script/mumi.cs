using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class mumi : MonoBehaviour
{
    public int idKue;    //id kue ga nanti buat ngecek sama apa engga sama di suruh ambil
    public int skorTab;
    public static int skor;// skor yang mau di tambahin ke skor
    public int koinTab ;
    public static int koin=0;
    public float penambahFaktorCepat;  // penambah kecepatan ngisinya jangan banyak"
    public float batasBawahHilang;    // batas posisi y pas hilang (disamain sama generate random batasYbawah)
    public float speedAwal;       // inisialisasi kecepatan 
       public int Nyawa ; //public Transform objnametextPos;  // posisi object buat keluar animasi engga perlu soalnya bisa akses posisi kue diri sendiri
    public Transform succesclick;    // prefab animasi...
 

    // Use this for initialization
    void Start () {
        GameObject.FindGameObjectWithTag("Nyawa").GetComponent<Text>().text =
    (int.Parse(GameObject.FindGameObjectWithTag("Nyawa").GetComponent<Text>().text) + Nyawa).ToString();
      

    }
	
	// Update is called once per frame
	void Update () {
      
        // kalo udah sampe batas bawah ganti posisi
        if (transform.position.y < batasBawahHilang)
	    {
	        transform.position = generatePosXYZ();
	    }
        //kalo belum sampe batas bawah tambah kecepatannya;
	    else
	    {
            transform.position = new Vector3(transform.position.x,transform.position.y - speedAwal * Time.deltaTime,transform.position.z);
	        speedAwal += penambahFaktorCepat;
	    }
    
	}

    //untuk generate Random posisi kue nya
    private Vector3 generatePosXYZ()
    {
        //batas" posisi random (variabel float harus ditambah "f" dibelakang angka di C#)
        float _batasXKiri = -2.54f; 
        float _batasXKanan = 2.54f;
        float _batasYAtas = 3.8f;
        float _batasYBawah = -4.0f;
        float z = 0;
        return new Vector3(Random.Range(_batasXKiri,_batasXKanan),Random.Range(_batasYBawah,_batasYAtas),z);

    }

    //Pas di klik nambah skor sama generate posisi lagi....
    public void OnMouseDown()
    {
         ObjectiveKue temp = GameObject.FindGameObjectWithTag("panutan").GetComponent<ObjectiveKue>();
        // keluar animasi sparkie
      

         if (temp.IDKueSaatIni == idKue && Nyawa > 0)                                                                // check kue apakah benar dengan panutan
        {
            temp.randomIDKue();
            temp.gantiSpriteKue();
            Instantiate(succesclick, transform.position, succesclick.rotation);
      
                GameObject.FindGameObjectWithTag("koin").GetComponent<Text>().text =
                (int.Parse(GameObject.FindGameObjectWithTag("koin").GetComponent<Text>().text) + koinTab).ToString();
            // nambah skor
            koin = koin + koinTab;
            GameObject.FindGameObjectWithTag("skor").GetComponent<Text>().text =
                    (int.Parse(GameObject.FindGameObjectWithTag("skor").GetComponent<Text>().text) + skorTab).ToString();
                skor = ObjectTab.skor + skorTab;
            transform.position = generatePosXYZ();
        }


                // nambah koin


        // kalau tidak sesuai dengan panutan kue

        else if (temp.IDKueSaatIni != idKue && Nyawa > 0)
        {
            Nyawa = -1;
            GameObject.FindGameObjectWithTag("Nyawa").GetComponent<Text>().text =
    (int.Parse(GameObject.FindGameObjectWithTag("Nyawa").GetComponent<Text>().text) - 1).ToString();
            // nambah koin

            // GameObject.FindGameObjectWithTag("skor").GetComponent<Text>().text =
            //     (int.Parse(GameObject.FindGameObjectWithTag("skor").GetComponent<Text>().text) - 2).ToString();  // mengurangi skor dengan 2
            transform.position = generatePosXYZ();

        }

                    else if (Nyawa<=0)
        {

            Application.LoadLevel("gameover");

        }// generate posisi baru
    }



}
