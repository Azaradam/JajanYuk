using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour {

    public GameObject Barinfo;
    public GameObject Bubble;

	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Jeus()
    {
        CameraController.ShopButton = true;
        CameraController.StreetButton = false;
        Barinfo.SetActive(true);
        Bubble.SetActive(false);
    }
}
