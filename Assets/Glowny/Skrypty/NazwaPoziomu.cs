using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NazwaPoziomu : MonoBehaviour {

    public TextMesh nazwaPoziomu;

	// Use this for initialization
	void Start () {
        string nazwaPoziomu_2 = SceneManager.GetActiveScene().name;
        nazwaPoziomu.text = nazwaPoziomu_2;
	}
}
