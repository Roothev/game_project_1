using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misja_1_zbierz_ksiazki : MonoBehaviour {

    public GameObject Przeszkoda;
    public bool CzyZniszczycPrzeszkode;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log(ilosc_ksiazek());
            if ((ilosc_ksiazek() == 1) && (CzyZniszczycPrzeszkode==true))
            {
                Destroy(Przeszkoda);
            }
        }
    }

    int ilosc_ksiazek()
    {
        misja_1_zbierz_ksiazki[] ksiazki = FindObjectsOfType<misja_1_zbierz_ksiazki>();
        return ksiazki.Length;
    }
}
