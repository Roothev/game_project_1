using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrzejscieDoSceny : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string ScenaPrzejsciowa;
    public bool CzyZaladowacScene;

    void OnTriggerEnter(Collider other)
    {
        if (CzyZaladowacScene == true)
        {
            if (other.tag == "Player")
            {
                SceneManager.LoadScene(ScenaPrzejsciowa);
            }
        }
    }
}
