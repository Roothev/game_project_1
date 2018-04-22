using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Glowne : MonoBehaviour {

    public RuchPostaci Gracz;
    public bool jestAktywneOkno;
    bool przestanRuszacPostacia;
    public GameObject podmenu;
    public TextBoxMenager textBox;

	// Use this for initialization
	void Start () {
        if (SceneManager.GetActiveScene().name != "menu")
        {
            Gracz = FindObjectOfType<RuchPostaci>();
            podmenu.SetActive(false);
            jestAktywneOkno = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
        //WlaczMenu();

        if (SceneManager.GetActiveScene().name != "menu")
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                WidacOknoMenu();
            }

            if (!jestAktywneOkno)
            {
                return;
            }
        }
	}

    public void NowaGra() {
        SceneManager.LoadScene("Scena_01");
    }

    public void MapaPoziomow()
    {
        SceneManager.LoadScene("mapa");
    }

    public void ResetujScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NieWidacOknoMenu()
    {
        podmenu.SetActive(false);
        jestAktywneOkno = false;
        if (textBox.jestAktywneOkno != true)
        {
            Gracz.mozliwy_ruch = true;
        }
        
    }

    public void WidacOknoMenu()
    {
        podmenu.SetActive(true);
        jestAktywneOkno = true;
        Gracz.mozliwy_ruch = false;
    }


    public void PowrotDoMenuGlownego() {

            SceneManager.LoadScene(0);
    }

    public void WylaczGreButton() {
        Application.Quit();
    }
}
