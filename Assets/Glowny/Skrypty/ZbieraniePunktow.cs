using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZbieraniePunktow : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider kolizja)
    {
        if (kolizja.gameObject.name == "Gracz")
        {
            Destroy(gameObject);
        }
    }
}
