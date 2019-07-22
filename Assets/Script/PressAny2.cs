using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressAny2 : MonoBehaviour {

    private int any1;
    public GameObject  Skip;
    public GameObject Klik;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.anyKeyDown)
        {
            if (any1 == 2)
            {
                Klik.GetComponent<Click>().ResetGame();
                PlayerPrefs.SetInt("NewGame", 1);
            }
            if (any1 == 0)
            {
                any1 = 2;
                Skip.SetActive(true);
            }
            

        }

    }
}
