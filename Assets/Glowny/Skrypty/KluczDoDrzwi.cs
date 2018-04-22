using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KluczDoDrzwi : MonoBehaviour {

    public OtwieranieDrzwi Drzwi;

	// Use this for initialization
	void Start () {
        //Drzwi = FindObjectOfType<OtwieranieDrzwi>();
	}
	
	// Update is called once per frame

    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Drzwi.CzyOtwierac = true;
            Destroy(gameObject);
        }
    }
}
