using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {

    private int NewGame;
    public GameObject Canvas;

    public GameObject ttrl1, ttrl2, ttrl3, ttrl4,ttrl5,ttrl6;

    public Text tutorText1,tutorText2,tutorText3,tutorText4,tutorText5,tutorText6;
    public string[] tutorTextIsi;

    public float score;
    public int gold;

    public Collider2D Kolider1;
    public GameObject qwe, rty, uio;
    

	// Use this for initialization
	void Start () {
        
        NewGame = PlayerPrefs.GetInt("NewGame");

    }
	
	// Update is called once per frame
	void Update () {
        GameObject Manager = GameObject.Find("ClickArea");
        Click otherScript = Manager.GetComponent<Click>();
        score = (float)Manager.GetComponent<Click>().score;
        gold = Manager.GetComponent<Click>().gold;


        Debug.Log("is " + score);
        Debug.Log(NewGame);
        Debug.Log("count" + Baten.tutorialCount);

        tutorText1.text = (tutorTextIsi[Baten.tutorialCount]);
        tutorText2.text = (tutorTextIsi[Baten.tutorialCount]);
        tutorText3.text = (tutorTextIsi[Baten.tutorialCount]);
        tutorText4.text = (tutorTextIsi[Baten.tutorialCount]);
        tutorText5.text = (tutorTextIsi[Baten.tutorialCount]);
        tutorText6.text = (tutorTextIsi[Baten.tutorialCount]);
        if (NewGame == 1)
        {
            if (Baten.tutorialCount == 1)
            {
                ttrl1.SetActive(true);
                Kolider1.enabled=false;
                qwe.SetActive(false);
                rty.SetActive(false);
                uio.SetActive(false);
            }

            if (Baten.tutorialCount == 3)
            {
                if (score == 0)
                {
                    ttrl1.SetActive(false);
                    ttrl2.SetActive(true);
                }
            }
            if (Baten.tutorialCount == 4)
            {
                if(score != 3)
                {
                    Kolider1.enabled = true;
                    qwe.SetActive(true);
                    rty.SetActive(true);
                    uio.SetActive(true);
                }
                if (score == 3)
                {
                    Kolider1.enabled = false;
                    qwe.SetActive(false);
                    rty.SetActive(false);
                    uio.SetActive(false);
                    ttrl2.SetActive(false);
                    ttrl3.SetActive(true);
                }
            }
            if (Baten.tutorialCount == 5)
            {
                ttrl3.SetActive(false);
                if (Click.level != 2)
                {
                    Kolider1.enabled = true;
                    qwe.SetActive(true);
                    rty.SetActive(true);
                    uio.SetActive(true);

                }
                if (Click.level == 2)
                {
                    Kolider1.enabled = false;
                    qwe.SetActive(false);
                    rty.SetActive(false);
                    uio.SetActive(false);
                    ttrl2.SetActive(false);
                    ttrl3.SetActive(true);
                    ttrl3.SetActive(false);
                    ttrl4.SetActive(true);
                }
            }
            if (Baten.tutorialCount == 6)
            {
                ttrl4.SetActive(false);
                ttrl5.SetActive(true);
                
            }
            if (Baten.tutorialCount == 7)
            {
                Kolider1.enabled = true;
                qwe.SetActive(true);
                rty.SetActive(true);
                uio.SetActive(true);
                ttrl5.SetActive(false);

                if (gold == 10)
                {
                    Kolider1.enabled = false;
                    qwe.SetActive(false);
                    rty.SetActive(false);
                    uio.SetActive(false);
                    ttrl5.SetActive(false);
                    ttrl6.SetActive(true);
                }
                if (gold == 0)
                {
                    Kolider1.enabled = true;
                    qwe.SetActive(true);
                    rty.SetActive(true);
                    uio.SetActive(true);
                    ttrl6.SetActive(false);
                    Baten.tutorialCount++;
                }
            }


        }

    }
}
