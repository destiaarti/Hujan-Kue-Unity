using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lalat : MonoBehaviour {
    public float penambahFaktorCepat;  // penambah kecepatan ngisinya jangan banyak"
    public float batasBawahHilang;    // batas posisi y pas hilang (disamain sama generate random batasYbawah)
    public float speedAwal;
    public float timeLeft;
    public float timel;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        timel -= Time.deltaTime;
        if (timel <= timeLeft)
        {
            if (transform.position.y < batasBawahHilang)
            {
                transform.position = generatePosXYZ();
                timel = 0;
            }
            //kalo belum sampe batas bawah tambah kecepatannya;
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - speedAwal * Time.deltaTime, transform.position.z);
                speedAwal += penambahFaktorCepat;

            }
        
      
        }
    }
    private Vector3 generatePosXYZ()
    {
        //batas" posisi random (variabel float harus ditambah "f" dibelakang angka di C#)
        float _batasXKiri = -2.54f;
        float _batasXKanan = 2.54f;
        float _batasYAtas = 3.8f;
        float _batasYBawah = -4.0f;
        float z = 0;
        return new Vector3(Random.Range(_batasXKiri, _batasXKanan), Random.Range(_batasYBawah, _batasYAtas), z);

    }

    //Pas di klik nambah skor sama generate posisi lagi....
    public void OnMouseDown()
    {
        if (timel <= timeLeft)
        {
            Application.LoadLevel("awal");
        }
        else
        {

        }
    }
}
