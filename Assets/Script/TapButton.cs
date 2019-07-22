using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapButton : MonoBehaviour {


    public GameObject ttrl2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            Baten.tutorialCount++;
            ttrl2.SetActive(false);

            
        }
    }
}
