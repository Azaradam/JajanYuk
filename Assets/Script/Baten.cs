using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Baten : MonoBehaviour {

    public GameObject Klepon;
    public GameObject OndeOnde;
    public GameObject Menu;
    public GameObject Credit;
    public GameObject SoundButtonMengecil;
    public GameObject SoundButtonMembesar;
    public GameObject Soundoke;
    public GameObject SoundBGM;
    public GameObject SoundBGM2;

    public GameObject SFXButtonMengecil;
    public GameObject SFXButtonMembesar;
    public GameObject SFXoke;
    public GameObject ClickSFX;
    public GameObject COIN;
    public GameObject HIT;
    public GameObject EXP;
    AudioSource AudioSource;
    public GameObject Tameng;
    public GameObject Tameng2;
    public GameObject ExitMenu;

    public AudioSource ButtonSFX;

    public GameObject Bubble;

    public Text TextBubble;
    public string[] IsiBubble;


    public GameObject Klik;

    private int NewGame = 1;

    public static int tutorialCount = 1;

    // Use this for initialization
    void Start () {

        SoundBGM = GameObject.Find("BGM");
        SoundBGM2 = GameObject.Find("BGM2");
        ClickSFX = GameObject.Find("ClickSFX");
        COIN = GameObject.Find("COIN");
        HIT = GameObject.Find("HIT");
        EXP = GameObject.Find("EXP");
        ButtonSFX = GameObject.Find("ButtonSFX").GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void gajadi()
    {
        ButtonSFX.Play();
        Klepon.SetActive(false);
        OndeOnde.SetActive(false);
        Menu.SetActive(false);
        Tameng.SetActive(false);
        ExitMenu.SetActive(false);
    }
    public void KleponDesc()
    {
        ButtonSFX.Play();
        Klepon.SetActive(true);
        Tameng.SetActive(true);
    }
    public void OndeOndeDesc()
    {
        ButtonSFX.Play();
        OndeOnde.SetActive(true);
        Tameng.SetActive(true);
    }
    public void MenuMenu()
    {
        ButtonSFX.Play();
        Menu.SetActive(true);
        Tameng.SetActive(true);
    }
    public void CreditMenu()
    {
        ButtonSFX.Play();
        Credit.SetActive(true);
        Menu.SetActive(false);
        Tameng.SetActive(true);


    }
    public void CreditMenuBack()
    {
        ButtonSFX.Play();
        Credit.SetActive(false);
        Menu.SetActive(true);
        Tameng.SetActive(true);
    }
    public void SoundOptionMengecil()
    {
        SoundBGM.GetComponent<AudioSource>().volume = 0f;
        SoundBGM2.GetComponent<AudioSource>().volume = 0f;
        SoundButtonMengecil.SetActive(false);
        SoundButtonMembesar.SetActive(true);
        Soundoke.SetActive(false);
    }
    public void SoundOptionMembesar()
    {
        SoundBGM.GetComponent<AudioSource>().volume = 0.509f;
        SoundBGM2.GetComponent<AudioSource>().volume = 0.509f;

        SoundButtonMengecil.SetActive(true);
        SoundButtonMembesar.SetActive(false);
        Soundoke.SetActive(true);
    }

    public void SFXOptionMengecil()
    {
        ClickSFX.GetComponent<AudioSource>().volume = 0f;
        COIN.GetComponent<AudioSource>().volume = 0f;
        EXP.GetComponent<AudioSource>().volume = 0f;
        HIT.GetComponent<AudioSource>().volume = 0f;
        SFXButtonMengecil.SetActive(false);
        SFXButtonMembesar.SetActive(true);
        SFXoke.SetActive(false);
    }
    public void SFXOptionMembesar()
    {
        ClickSFX.GetComponent<AudioSource>().volume = 1f;
        COIN.GetComponent<AudioSource>().volume = 1f;
        EXP.GetComponent<AudioSource>().volume = 1f;
        HIT.GetComponent<AudioSource>().volume = 1f;
        SFXButtonMengecil.SetActive(true);
        SFXButtonMembesar.SetActive(false);
        SFXoke.SetActive(true);
    }

    public void Memulai()
    {
        Debug.Log("test");
        if (PressAny.time >= 2.5f)
        {

            NewGame = PlayerPrefs.GetInt("NewGame");
            if (NewGame == 1)
            {
                SceneManager.LoadScene(1);
                //Click.ResetGame2();
                PlayerPrefs.SetInt("NewGame", 1);
            }
            else
            {
                Klik.GetComponent<Click>().ResetGame();
                PlayerPrefs.SetInt("NewGame", 1);
            }
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void BubblePop()
    {
        Bubble.SetActive(false);
        Bubble.SetActive(true);
        TextBubble.text = (IsiBubble[Random.Range(0, IsiBubble.Length)]);
    }
    public void Tutorial()
    {
        tutorialCount++;
    }
}
