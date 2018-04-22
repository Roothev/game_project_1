using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Importer_Textu : MonoBehaviour {

    //juz tego nie uzywam mam w text box menadrzerze

    public TextAsset textFile;
    public string[] textLines;

	// Use this for initialization
	void Start () {

        if(textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }

	}
	
	// Update is called once per frame
	//void Update () {
		
	//}
}
