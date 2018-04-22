using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtwieranieDrzwi : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Animator Animator_drzwi;
    public bool CzyOtwierac;

    void OnTriggerStay(Collider other)
    {
        if (CzyOtwierac == true)
        {
            if (other.tag == "Player")
            {
                //Animator_drzwi.SetTrigger("Otworz_Drzwi");
                Animator_drzwi.SetBool("Otworz_Drzwi", true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Animator_drzwi.SetBool("Zamknij_Drzwi", true);
            Animator_drzwi.SetBool("Otworz_Drzwi", false);
        }
    }

}
