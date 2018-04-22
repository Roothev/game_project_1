using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxMenager : MonoBehaviour {

    public GameObject textBox;
    public Text theText;
    public Menu_Glowne menu;

    public TextAsset textFile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;

    //public GraczControler Gracz;
    public RuchPostaci Gracz;

    public bool jestAktywneOkno;
    public bool przestanRuszacPostacia;

    // Use this for initialization
    void Start()
    {
        //Gracz = FindObjectOfType<GraczControler>();
        Gracz = FindObjectOfType<RuchPostaci>();

        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }

        if (endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }

        if (jestAktywneOkno)
        {
            WidacOkno();
        }
        else
        {
            NieWidacOkna();
        }

    }

	// Update is called once per frame
	void Update () 
    {

        if (!jestAktywneOkno)
        {
            return;
        }

        theText.text = textLines[currentLine];

        if (menu.jestAktywneOkno != true)
        {
            if (Input.GetKeyDown(KeyCode.RightControl))
            {
                if (currentLine < endAtLine)
                {
                    currentLine += 1;
                }
                else
                {
                    NieWidacOkna();
                }

            }
        }

    

	}

        public void WidacOkno()
        {
            textBox.SetActive(true);
            jestAktywneOkno = true;

            if (przestanRuszacPostacia)
            {
                Gracz.mozliwy_ruch = false;
            }

            Gracz.mozliwy_ruch = false;
        }

        public void NieWidacOkna()
        {
            textBox.SetActive(false);
            jestAktywneOkno = false;
            if (menu.jestAktywneOkno != true)
            {
                Gracz.mozliwy_ruch = true;
            }
            
        }

        public void PonownyOdczytSkryptu(TextAsset theText)
        {
            if (theText != null)
            {
                textLines = new string[1];
                textLines = (theText.text.Split('\n'));
            }
        }
}
