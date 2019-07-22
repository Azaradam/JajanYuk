using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public static bool StreetButton = false;
    public GameObject StrBtn;
    public static bool ShopButton = true;
    public GameObject ShpBtn;
    private bool Dijalan = false;

	// Use this for initialization
	void Start () {

        //Screen.SetResolution(640, 480, true);
		
	}
	
	// Update is called once per frame
	void Update () {
        if (StreetButton)
        {
            transform.position = new Vector3(27f, 0, -10);
            StrBtn.SetActive(false);
            ShpBtn.SetActive(true);
            ShopButton = false;
            Dijalan = true;

        }
        else if(Dijalan){
            if (ShopButton)
            {
                transform.position = new Vector3(0, 0, -10);
                ShpBtn.SetActive(false);
                StrBtn.SetActive(true);
                StreetButton = false;
                Dijalan = false;
            } }

    }
}
