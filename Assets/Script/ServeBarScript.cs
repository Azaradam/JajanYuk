using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ServeBarScript : MonoBehaviour {


    Image scoreBar;
    float maxScore;
    float maxBoss;
    public static float score;
	// Use this for initialization
	void Start () {
        scoreBar = GetComponent<Image>();
    

    }
	
	// Update is called once per frame
	void Update () {
        GameObject Manager = GameObject.Find("ClickArea");
        Click otherScript = Manager.GetComponent<Click>();
        maxScore = (float)Manager.GetComponent<Click>().scorecap;
        score = (float)Manager.GetComponent<Click>().score;
        maxBoss = (float)Manager.GetComponent<Click>().bosscap;

        if (Click.bossbattle == "true")
        {
            scoreBar.fillAmount = score / maxBoss;
        }
        else
        scoreBar.fillAmount = score / maxScore;
		
	}
}
