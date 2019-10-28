using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ObjectTab : MonoBehaviour
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
    public Transform gagalklik;


    // Use this for initialization
    void Start () {
        GameObject.FindGameObjectWithTag("Nyawa").GetComponent<Text>().text =
    (int.Parse(GameObject.FindGameObjectWithTag("Nyawa").GetComponent<Text>().text) + Nyawa).ToString();
      

    }

    // Update is called once per frame
    void Update()
    {
        if (idKue == 3)
        {
            if (pindah1.su == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
       else if (idKue == 4)
        {
            if (pindah1.su1 == true)
        {
            // kalo udah sampe batas bawah ganti posisi
            if (transform.position.y < batasBawahHilang)
            {
                transform.position = generatePosXYZ();
            }
            //kalo belum sampe batas bawah tambah kecepatannya;
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                speedAwal += penambahFaktorCepat;
            }
        }
        else { speedAwal = 0; }
    }
        else if (idKue == 5)
        {
            if (pindah1.su2 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 6)
        {
            if (pindah1.su3 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 7)
        {
            if (pindah1.su4 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 8)
        {
            if (pindah1.su5 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 9)
        {
            if (pindah1.su6 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 10)
        {
            if (pindah1.su7 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 11)
        {
            if (pindah1.su8 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 12)
        {
            if (pindah1.su9 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 13)
        {
            if (pindah1.su10 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 14)
        {
            if (pindah1.su11 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 15)
        {
            if (pindah1.su12 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 16)
        {
            if (pindah1.su13 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 17)
        {
            if (pindah1.su14 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 18)
        {
            if (pindah1.su15 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 19)
        {
            if (pindah1.su16 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 20)
        {
            if (pindah1.su17 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else if (idKue == 21)
        {
            if (pindah1.su18 == true)
            {
                // kalo udah sampe batas bawah ganti posisi
                if (transform.position.y < batasBawahHilang)
                {
                    transform.position = generatePosXYZ();
                }
                //kalo belum sampe batas bawah tambah kecepatannya;
                else
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                    speedAwal += penambahFaktorCepat;
                }
            }
            else { speedAwal = 0; }
        }
        else
        {
            // kalo udah sampe batas bawah ganti posisi
            if (transform.position.y < batasBawahHilang)
            {
                transform.position = generatePosXYZ();
            }
            //kalo belum sampe batas bawah tambah kecepatannya;
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                speedAwal += penambahFaktorCepat;
            }
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
                skor = skor + skorTab;
            transform.position = generatePosXYZ();
        }


                // nambah koin


        // kalau tidak sesuai dengan panutan kue

        else if (temp.IDKueSaatIni != idKue && Nyawa > 0)
        {
            Instantiate(gagalklik, transform.position, gagalklik.rotation);
            Nyawa = -1;
            GameObject.FindGameObjectWithTag("Nyawa").GetComponent<Text>().text =
    (int.Parse(GameObject.FindGameObjectWithTag("Nyawa").GetComponent<Text>().text) - 1).ToString();
            // nambah koin

            // GameObject.FindGameObjectWithTag("skor").GetComponent<Text>().text =
            //     (int.Parse(GameObject.FindGameObjectWithTag("skor").GetComponent<Text>().text) - 2).ToString();  // mengurangi skor dengan 2
            transform.position = generatePosXYZ();

        }

        else if (Nyawa <=0)
        {

            Application.LoadLevel("gameover");

        }// generate posisi baru
        else
        {

        }
    }



}
