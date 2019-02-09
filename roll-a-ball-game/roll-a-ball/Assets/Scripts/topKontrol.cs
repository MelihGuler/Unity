using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topKontrol : MonoBehaviour {

    private Rigidbody fizik;
    private int sayac = 0;
    private int toplanacakObjeSayisi = 12;
    private Text sayacTxt,oyunBittiTxt;
	void Start () {
        GameObject getir = GameObject.Find("sayac");
        sayacTxt = getir.GetComponent<Text>();
        sayacTxt.text = "Toplanılan: 0";
        GameObject oyunBittiGetir = GameObject.Find("oyunBitti");
        oyunBittiTxt = oyunBittiGetir.GetComponent<Text>();
        fizik = GetComponent<Rigidbody>();
	}

    private float yatay, dikey;
    private Vector3 vector3;
    void FixedUpdate () {
         yatay = Input.GetAxisRaw("Horizontal");
         dikey = Input.GetAxisRaw("Vertical");
        vector3 = new Vector3(yatay, 0, dikey);
        fizik.AddForce(vector3*10);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="engel")
        {
            other.gameObject.SetActive(false);
            sayac++;
            sayacTxt.text = "Toplanılan: " + sayac;
        }
        if (sayac == toplanacakObjeSayisi)
        {
            oyunBittiTxt.text="OYUN BİTTİ !";
        }
    }
}
