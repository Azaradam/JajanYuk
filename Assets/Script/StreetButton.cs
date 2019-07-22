using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetButton : MonoBehaviour {

    public GameObject Barinfo;
    public GameObject Bubble;
    public GameObject baten;

	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Jeus()
    {
        CameraController.StreetButton = true;
        CameraController.ShopButton = false;
        Barinfo.SetActive(false);
        //Bubble.SetActive(true);
        baten.GetComponent<Baten>().BubblePop();
    }
}
