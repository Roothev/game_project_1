using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuchPostaci : MonoBehaviour {

    public bool mozliwy_ruch;
    public Animator AnimacjaPostaci;
    public int ilosc_punktow;
    public Text tekst;

    //test
    public float predkosc = 10.0F;
    public float predkoscObrotu = 105.0F;

    //test

	// Use this for initialization
	void Start () {
        ilosc_punktow = 0;
        AnimacjaPostaci.SetBool("MaIsc", false);
	}
	
	// Update is called once per frame
	void Update () {

        if (!mozliwy_ruch)
        {
            AnimacjaPostaci.SetBool("MaIsc", false);
            return;
        }

        tekst.text = ilosc_punktow.ToString();

        ruchPostaci();
	}

    void ruchPostaci()
    {
        //test
        AnimacjaPostaci.SetBool("MaIsc", true);
        float translation = Input.GetAxis("Vertical") * predkosc;
        float obrot = Input.GetAxis("Horizontal") * predkoscObrotu;
        translation *= Time.deltaTime;
        obrot *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, obrot, 0);

        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            AnimacjaPostaci.SetBool("MaIsc", false);
        }
        //test
    }


/*
    void ruchPostaci()
    {
        //transform to obiekt ktory ejst powiazany ze skryptem

         //RUCH W PRZOD
        if (Input.GetKey(KeyCode.UpArrow))
        {
            AnimacjaPostaci.SetBool("MaIsc", true);
            transform.position = transform.position + (transform.forward * 0.2f);
        }

        //RUCH W TYL
        if (Input.GetKey(KeyCode.DownArrow))
        {
            AnimacjaPostaci.SetBool("MaIsc", true);
            transform.position = transform.position - (transform.forward * 0.2f);
        }

        //OBROT W LEWO
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            AnimacjaPostaci.SetBool("MaIsc", true);
            transform.obrot *= Quaternion.Euler(0, -2f, 0);
            //-1f na -5f
        }

        //OBROT W PRAWO
        if (Input.GetKey(KeyCode.RightArrow))
        {
            AnimacjaPostaci.SetBool("MaIsc", true);
            transform.obrot *= Quaternion.Euler(0, 2f, 0);
        }

        //Skok- poki co nie dziala
        //if (Input.GetKey(KeyCode.Space))
        //{
          //  AnimacjaPostaci.SetBool("MaIsc", true);
           // transform.up = transform.up - (transform.up * 0.2f);
       // }


        //transform.obrot *= Quaternion.Euler(0,180f,0);

        //Lewo do przodu, prawo do tyłu, jesli widok z boku

        //BEZCZYNNOSC

        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.Space))
        {
            AnimacjaPostaci.SetBool("MaIsc", false);
            //AnimacjaPostaci.SetBool("MaSkoczyc", false);
        }

        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            AnimacjaPostaci.SetBool("MaIsc", false);
        }
    }

 */
    void OnTriggerEnter(Collider kolizja)
    {
        if (kolizja.gameObject.tag == "Punkty")
        {
            ilosc_punktow = ilosc_punktow + 1;
            //Debug.Log("Ilosc punktow: " + ilosc_punktow);
        }
    }
}
