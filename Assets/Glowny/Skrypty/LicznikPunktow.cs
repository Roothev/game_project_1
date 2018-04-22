using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LicznikPunktow : MonoBehaviour {

    public RuchPostaci Gracz_zmienna;
    int liczba_punktow_gracza;


	// Use this for initialization
	void Start () {
        Gracz_zmienna = FindObjectOfType<RuchPostaci>();
        liczba_punktow_gracza = Gracz_zmienna.ilosc_punktow;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(liczba_punktow_gracza);
		
	}
}
