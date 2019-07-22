using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressAny : MonoBehaviour {


    public static float time = 0.0f;
    public float time2 = 0.0f;
    public GameObject Press;
    public GameObject Klik;
    public Animator animator;
    public GameObject white;
    private bool taim2=false;

    private int NewGame = 1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(time >= 2.2f)
        {
            if (taim2 == false)
            {
                Press.SetActive(true);
            }
            if (Input.anyKeyDown)
            {
                taim2 = true;
                white.SetActive(true);
                Press.SetActive(false);
                animator.SetTrigger("Preesss");
                
            }
        }

        time += UnityEngine.Time.deltaTime;

        if (taim2)
        {
            time2 += UnityEngine.Time.deltaTime;
        }

        if (time2 >= 1.0f)
        {
            Debug.Log("test");
            NewGame = PlayerPrefs.GetInt("NewGame");
            if (NewGame == 1)
            {
                SceneManager.LoadScene(1);
                //Click.ResetGame2();
                PlayerPrefs.SetInt("NewGame", 1);
            }
            else
            {
                SceneManager.LoadScene(2);
                //Klik.GetComponent<Click>().ResetGame();
                //PlayerPrefs.SetInt("NewGame", 1);
            }

        }
    }
}
