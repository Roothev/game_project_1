using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AktualizacjaTekstu : MonoBehaviour {

    public TextAsset theText;
    public int startLine;
    public int endLine;

    public TextBoxMenager theTextBox;
    public bool ZniszczGdySieAktywuje;

	// Use this for initialization
	void Start () {

        theTextBox = FindObjectOfType<TextBoxMenager>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Gracz")
        {
            theTextBox.PonownyOdczytSkryptu(theText);
            theTextBox.currentLine = startLine;
            theTextBox.endAtLine = endLine;
            theTextBox.WidacOkno();

            //by okienko sie już nie pojawiało
            if (ZniszczGdySieAktywuje)
            {
                Destroy(gameObject);
            }

        }
    }
}
