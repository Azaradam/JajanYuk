using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Click : MonoBehaviour {

    public Animator animator, landmarknimator;
    public float test = 0f;
    public int scorecap = 5; //Poin pesanan yang dibutuhkan untuk menyelesaikan pesanan
    public int expcap; //exp yang dibutuhkan untuk naik level (stage)
    public static int expget = 30;  //exp yang di dapatkan dari pelanggan
    private int goldget = 1; //gold yang didapat dari pelanggan

    public static int level = 12; //stage
    public int exp = 0;   //exp saat ini
    public int gold = 0;  //gold saat ini
    public float score;     //Poin pesanan saat in
    public int damage = 1; // jumlah yang didapat per klik
    public int auto = 0; // Kecepatan kerja karyawan
    public float period = 0.0f;


    public GameObject This;
    public static bool spawn;

    [Header("Music & SFX")]

    private AudioSource SFXHit;
    private AudioSource SFXCoin;
    private AudioSource SFXExp;
    private AudioSource SFXClick;
    private AudioSource SFXError;

    [Header("FX")]

    public GameObject Efek;
    public GameObject BossLogo;
    public GameObject Cahaya;
    private bool CahayaMeredup = false;
    public float timeefek = 0.0f;



    [Header("Food Upgrade")]

    public static int food1 = 10;  //harga upgrade makanan 1
    public static int food1g = 1;  //efek upgrade makanan 1

    public static int food2 = 100;  //harga upgrade makanan 2
    public static int food2g = 10;  //efek upgrade makanan 2

    public static int food3 = 5000;  //harga upgrade makanan 3
    public static int food3g = 150;  //efek upgrade makanan 3

    public static int food4 = 10000;  //harga upgrade makanan 4
    public static int food4g = 500;  //efek upgrade makanan 4

    public static int food5 = 1000000;  //harga upgrade makanan 5
    public static int food5g = 50;  //efek upgrade makanan 5

    public static int food6 = 1000000;  //harga upgrade makanan 6
    public static int food6g = 50;  //efek upgrade makanan 6

    public int food7 = 3000000;  //harga upgrade makanan 6
    public int food7g = 50;  //efek upgrade makanan 6

    private int bosslv = 4;
    private int bosslvh = 0;

    [Header("Facility Upgrade")]

    public int buildCost = 100; //harga upgrade gedung
    public int buildEff = 3000; //efek gedung, EXP (expget) yang didapat per pelanggan bertambah

    public int handCost = 1000; //harga
    public int handEff = 1; //efek upgrade tangan, meningkatkan kecepatan melayani pelanggan (tap) (damage)

    public int karyawanCost = 1500; //harga
    public int karyawanEff = 1; //kecepatan auto gold

    [Header("Spawn")]
    public Animator Anim, anm;
    public static bool selesai, diklik;
    public static int jujui = 1;
    public static bool jijai;

    //N
    private string NewGame = "true";

    [Header("Gerai")]

    //public GameObject gerai;
    public Sprite[] gerailist;
    public Sprite[] gerailist2;
    public GameObject gerailv1;


    [Header("Boss")]
    public float bosstime = 0.0f;
    public static string bossbattle = "false";
    private string bosslevel = "false";
    private GameObject Bext;
    public GameObject Manager;

    public int bosscap = 150;

    public GameObject tombolboss;

    public GameObject CancelText;
    public GameObject ResumeText;

    [Header("Buy Status")]

    private string OndeOnde = "false";
    private string KueLapis = "false";
    private string Putu = "false";
    private string Serabi = "false";
    private string Bakpia = "false";

    public GameObject LockOndeOnde;
    public GameObject LockKueLapis;
    public GameObject LockPutu;
    public GameObject LockSerabi;
    public GameObject LockBakpia;

    public int LevelKlepon = 1;
    public int LevelOndeOnde = 0;
    public int LevelKueLapis = 0;
    public int LevelPutu = 0;
    public int LevelSerabi = 0;
    public int LevelBakpia = 0;

    public int LevelTangan = 1;
    public int LevelGerai = 1;
    public int LevelKaryawan = 1;

    [Header("Background Level")]
    public GameObject BGLV1, BGLV2, BGLV3;
    public GameObject ExitMenu;
    public GameObject ExitOke;
    public GameObject TamengSeason4;

    public SpriteRenderer Klepon;
    public Sprite[] KleponUp;
    public SpriteRenderer OndeOndey;
    public Sprite[] OndeOndeUp;
    public SpriteRenderer KueLapys;
    public Sprite[] KueLapisUp;
    public SpriteRenderer Pwutu;
    public Sprite[] PutuUp;

    public SpriteRenderer Bekgron;
    public Sprite[] Bekgronup;
    private int LvBg = 1;

    public SpriteRenderer Geray;

    private float Volume ;
    public AudioSource BGM;
    public GameObject BGM2;

   


    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>


    void Start () {
        //bosslevel = "false";
        //bosslevel = "false";

        //if (NewGame == "false")
        //{
        //    NewGame = "false";
        //PlayerPrefs.SetString("NewGame", "false");
        //    ResetGame();

        //}

        Debug.Log("loaded");
        gold = PlayerPrefs.GetInt("gold");
        scorecap = PlayerPrefs.GetInt("scorecap");
        expcap = PlayerPrefs.GetInt("expcap");
        expget = PlayerPrefs.GetInt("expget");
        Debug.Log(expget);
        level = PlayerPrefs.GetInt("level");
        exp = PlayerPrefs.GetInt("exp");
        auto = PlayerPrefs.GetInt("auto");
        food1 = PlayerPrefs.GetInt("food1");
        food1g = PlayerPrefs.GetInt("food1g");
        food2 = PlayerPrefs.GetInt("food2");
        food2g = PlayerPrefs.GetInt("food2g");
        food3 = PlayerPrefs.GetInt("food3");
        food3g = PlayerPrefs.GetInt("food3g");
        food4 = PlayerPrefs.GetInt("food4");
        food4g = PlayerPrefs.GetInt("food4g");
        food5 = PlayerPrefs.GetInt("food5");
        food5g = PlayerPrefs.GetInt("food5g");
        food6 = PlayerPrefs.GetInt("food6");
        food6g = PlayerPrefs.GetInt("food6g");
        food1 = PlayerPrefs.GetInt("food1");
        food1g = PlayerPrefs.GetInt("food1g");
        buildCost = PlayerPrefs.GetInt("buildcost");
        buildEff = PlayerPrefs.GetInt("buildeff");
        handCost = PlayerPrefs.GetInt("handcost");
        handEff = PlayerPrefs.GetInt("handeff");
        karyawanCost = PlayerPrefs.GetInt("karyawancost");
        karyawanEff = PlayerPrefs.GetInt("karyawanEff");
        bosslevel = PlayerPrefs.GetString("bosslevel");
        //bossbattle = PlayerPrefs.GetString("bossbattle");
        bosscap = PlayerPrefs.GetInt("bosscap");
        OndeOnde = PlayerPrefs.GetString("OndeOnde");
        KueLapis = PlayerPrefs.GetString("KueLapis");
        Putu = PlayerPrefs.GetString("Putu");
        Serabi = PlayerPrefs.GetString("Serabi");
        Bakpia = PlayerPrefs.GetString("Bakpia");
        LevelKlepon = PlayerPrefs.GetInt("LevelKlepon");
        LevelOndeOnde = PlayerPrefs.GetInt("LevelOndeOnde");
        LevelKueLapis = PlayerPrefs.GetInt("LevelKueLapis");
        LevelPutu = PlayerPrefs.GetInt("LevelPutu");
        LevelSerabi = PlayerPrefs.GetInt("LevelSerabi");
        LevelBakpia = PlayerPrefs.GetInt("LevelBakpia");
        LevelTangan = PlayerPrefs.GetInt("LevelTangan");
        LevelGerai = PlayerPrefs.GetInt("LevelGerai");
        LevelKaryawan = PlayerPrefs.GetInt("LevelKaryawan");

        if (level % 5 == 0)
        {
            tombolboss.SetActive(true);
            bosslevel = "true"; 
        }
        else { bosslevel = "false"; }

        Bekgron.sprite = Bekgronup[Mathf.Clamp(LvBg, 0, 15)];
        //if (level == 6)
        //{
        //    BGLV1.SetActive(false);
        //    BGLV2.SetActive(true);
        //}






        ///////////////////////////////////////////
        expcap = (level * level) * scorecap * 5;
        spawn = true;
        jijai = true;

        Bext = GameObject.Find("TextManager").GetComponent<TextScript>().ngeboss;
        Bext.SetActive(false);
        tombolboss.SetActive(false);

        if (level % 5 == 0)
        {
            tombolboss.SetActive(true);
            bosslevel = "true";
        }
        else { bosslevel = "false"; }

        SFXExp = GameObject.Find("EXP").GetComponent<AudioSource>();
        SFXHit = GameObject.Find("HIT").GetComponent<AudioSource>();
        SFXCoin = GameObject.Find("COIN").GetComponent<AudioSource>();
        SFXClick = GameObject.Find("ClickSFX").GetComponent<AudioSource>();
        SFXError = GameObject.Find("ErrorSFX").GetComponent<AudioSource>();


        
    }
	
	// Update is called once per frame
	void Update () {

        //Debug.Log(expcap);
        //Debug.Log(expget);
        //Meja

        

        Klepon.sprite = KleponUp[Mathf.Clamp(LevelKlepon,0,5)];
        OndeOndey.sprite = OndeOndeUp[Mathf.Clamp(LevelOndeOnde,0,5)];
        Pwutu.sprite = PutuUp[Mathf.Clamp(LevelPutu, 0, 5)];
        KueLapys.sprite = KueLapisUp[Mathf.Clamp(LevelKueLapis,0,5)];

        if (level <= 6)
        {
            Geray.sprite = gerailist[Mathf.Clamp(LevelGerai, 1, 5)];
        }
        else
        {
            Geray.sprite = gerailist2[Mathf.Clamp(LevelGerai, 1, 5)];
        }

        //Status Upgrade

        if (OndeOnde == "true")
        {
            LockOndeOnde.SetActive(false);
        }

        if (KueLapis == "true")
        {
            LockKueLapis.SetActive(false);
        }

        if (Putu == "true")
        {
            LockPutu.SetActive(false);
        }

        if (Serabi == "true")
        {
            LockSerabi.SetActive(false);
        }

        if (Bakpia == "true")
        {
            LockBakpia.SetActive(false);
        }

        if (Input.GetKey("space"))
        {
            if (jijai)
            {
                score = score + damage;
                score++;
                if (!selesai)
                {
                    diklik = true;
                }
            }
            
        }

        //random

        test = 5f / 2f;

        //NaikLevel

        if (exp >= expcap)
        {
            exp = 0;
            level++;
            SFXExp.Play();
            if (level % 2 == 1)
            {
                scorecap = scorecap + 3;
            }
            else
            {
                scorecap = scorecap + 1;
            }
            if ((level - 1) % 5 == 0)
            {
                Debug.Log("tteetek");
                bosstime = 0f;
                Cahaya.SetActive(false);
                Cahaya.SetActive(true);
                landmarknimator.SetBool("Suramadu", false);
                landmarknimator.SetBool("Bandung", false);
                landmarknimator.SetBool("Padang", false);
                landmarknimator.SetBool("Jogja", false);
                CahayaMeredup = true;
                
                
                
            }

            expcap = (level * level) * scorecap * 4;
            goldget = goldget + (level);
            expget = expget + (level * scorecap);
        }

        SetBoss();
        //Debug.Log(BGM.volume);
        if (bossbattle == "true")
            {
                Bext = GameObject.Find("TextManager").GetComponent<TextScript>().ngeboss;
                Bext.SetActive(true);

                if (bosscap < score)
                {
                    bosstime = 0f;
                    bossbattle = "false";
                    bosslevel = "false";
                    selesai = true;
                    Bext.SetActive(false);
                }
                else
                    if (bosstime > 30f)
                {
                   
                    bosstime = 0f;
                    bossbattle = "false";
                    Bext.SetActive(false);
                }


            }

        //Debug.Log(bossbattle);
        if(level == 6)
        {
            Volume = BGM.volume;

            if (BGM.volume > 0)
            {
                BGM.volume -= Volume * UnityEngine.Time.deltaTime;
                //BGM.volume = Volume;
                //Debug.Log(BGM.volume);
            }
            //BGM.Stop();
        }

        //Scorecap non BOsS

        if (bosslevel == "false")
        {

            if (bossbattle == "false")
            {
                if (score >= scorecap)
                {
                    SFXCoin.Play();
                    score = 0;
                    gold = gold + goldget;
                    exp = exp + expget;
                    // diklik = false;
                    selesai = true;
                    //spawn = true;
                }
            }
            else
            {

                if (score >= scorecap)
                {
                    SFXCoin.Play();
                    score = 0;
                    gold = gold + goldget;
                    //exp = exp + expget;
                    selesai = true;
                }

            }
        }
        else
        if (bossbattle == "false")
        {
            if (score >= scorecap)
            {
                SFXCoin.Play();
                score = 0;
                gold = gold + goldget;
                //exp = exp + expget;
                selesai = true;
            }
        }

        //Auto Klik oleh Karyawan
        if (period > 1)
        {
            score = score + auto;
            period = 0;
        }
        period += UnityEngine.Time.deltaTime;
        bosstime += UnityEngine.Time.deltaTime;

       
        if (CahayaMeredup)
        {
            //animator.SetTrigger("ChangLevel");
            //animator.SetBool("ChangLevel",true);
            timeefek += UnityEngine.Time.deltaTime;
        }
        else { timeefek = 0f; }
        if (timeefek >= 2.0f)
        {


            //Cahaya.SetActive(false);
            //BGLV1.SetActive(false);
            //BGLV2.SetActive(true);
            LvBg++;
            Bekgron.sprite = Bekgronup[Mathf.Clamp(LvBg, 0, 15)];
            if(LvBg >= 13)
            {
                landmarknimator.SetBool("Suramadu",true);
            }
            else if (LvBg >= 10)
            {
                landmarknimator.SetBool("Padang", true);
            }
            else if (LvBg >= 7)
            {
                landmarknimator.SetBool("Bandung", true);
            }
            else if (LvBg >= 4)
            {
                landmarknimator.SetBool("Jogja", true);
            }
                //anim
                //anim
                //anim
                //animator.SetBool("ChangLevel", false);
                animator.SetTrigger("ChangLevel");
            CahayaMeredup = false;
            BGM2.SetActive(true);
            
            timeefek = 0.0f;

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TamengSeason4.SetActive(true);
            ExitMenu.SetActive(true);
        }

        
    }

    

    void boom ()
    {
    }

    void OnMouseDown()
    {
        if (jijai)
        {
            SFXClick.Play();
            score = score + damage;
            Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pz.z = 0;
            //gameObject.transform.position = pz;
            Instantiate(Efek, pz, Quaternion.identity);
            if (!selesai)
            {
                diklik = true;
            }
        }

        }
    public void Food1()
    {
        if (gold >= food1) { LevelKlepon++; SFXHit.Play(); gold = gold - food1; food1 = food1 + (2*LevelKlepon); goldget = goldget + food1g; food1g = food1g + (1 + LevelKlepon);  }
        else { SFXError.Play(); }
    }

    public void Food2()
    {
        if (gold >= food2) { LevelOndeOnde++; OndeOnde = "true";  SFXHit.Play(); gold = gold - food2; food2 = food2 * 3; goldget = goldget + food2g; }
        else { SFXError.Play(); }
    }
    public void Food3()
    {
        if (gold >= food3) { LevelKueLapis++; KueLapis = "true"; SFXHit.Play(); gold = gold - food3; food3 = food3 * 2; goldget = goldget + food3g; }
        else { SFXError.Play(); }
    }
    public void Food4()
    {
        if (gold >= food4) { LevelPutu++; Putu = "true"; SFXHit.Play(); gold = gold - food4; food4 = food4 * 2; goldget = goldget + food4g; }
        else { SFXError.Play(); }
    }
    public void Food5()
    {
        if (gold >= food5) { LevelSerabi++; Serabi = "true"; SFXHit.Play(); gold = gold - food5; food5 = food5 * 2; goldget = goldget + food5g; }
        else { SFXError.Play(); }
    }
    public void Food6()
    {
        if (gold >= food6) { LevelBakpia++; Bakpia = "true"; SFXHit.Play(); gold = gold - food6; food6 = food6 * 2; goldget = goldget + food6g; }
        else { SFXError.Play(); }
    }
    public void CancelBoss()
    {
        if (bossbattle == "true")
        {
            bosstime = 0f;
            bossbattle = "false";
            Bext.SetActive(false);

            ResumeText.SetActive(true);
            CancelText.SetActive(false);

            score = 0;
            selesai = true;
            //spawn = true;
        }
        else
        {
            bosstime = 0f;
            bossbattle = "true";
            Bext.SetActive(true);

            Instantiate(BossLogo, new Vector2(transform.position.x, transform.position.y + 0f), Quaternion.identity);

            CancelText.SetActive(true);
            ResumeText.SetActive(false);

            score = 0;
            spawn = true;

        }
    }
    


    public void Building()
    {
        if (gold >= buildCost) 
		{ 
        SFXHit.Play();
            LevelGerai++;
            gold = gold - buildCost; 
		buildCost = buildCost * 2;
		buildEff = buildEff + 4000;
		expget = expget + buildEff;

            //if (gerai != null)
            //    {Destroy(gerai);}

            //gerailv1.SetActive(false);
            //gerai = Instantiate(gerailist[LevelGerai-1], new Vector2(transform.position.x + 27f, transform.position.y - 3.5f), Quaternion.identity);
        
        }
        else { SFXError.Play(); }
    }
    public void Hand()
    {
        if (gold >= handCost) 
		{
        SFXHit.Play();
            LevelTangan++;
            gold = gold - handCost; 
		handCost = handCost * 2 + 400; 
		damage = damage + handEff; 
		}
        else { SFXError.Play(); }
    }

    public void citduit()
    {
        gold = gold + 99999;
    }
    public void Auto()
    {
        if (gold >= karyawanCost)
        {
            SFXHit.Play();
        LevelKaryawan++;
         
		gold = gold - karyawanCost;
		karyawanCost = karyawanCost * 2;
		auto = auto + karyawanEff; 
		}
        else { SFXError.Play(); }

    }

    void SetBoss() {
        //Darisini
        if (bosslevel == "false")
        {
            if (level % 5 == 0)
            {
                Instantiate(BossLogo, new Vector2(transform.position.x, transform.position.y + 0f), Quaternion.identity);
                bosslevel = "true";
                bossbattle = "true";
                tombolboss.SetActive(true);
                bosstime = 0f;
            }
        }
        if (bossbattle == "true")
        {
            Bext = GameObject.Find("TextManager").GetComponent<TextScript>().ngeboss;
            Bext.SetActive(true);
            tombolboss.SetActive(true);
            //Instantiate(BossLogo, new Vector2(transform.position.x, transform.position.y + 0f), Quaternion.identity);

            if (bosscap <= score)
            {
                bosstime = 0f;
                bossbattle = "false";
                bosslevel = "false";
                Bext.SetActive(false);
                tombolboss.SetActive(false);

                score = 0;
                gold = gold + goldget;
                exp = exp + expcap;
                bosscap = bosscap + 170;
                selesai = true;

                
                //spawn = true;
            }
            else
                if (bosstime >= 30f)
            
                {
                bosstime = 0f;
                bossbattle = "false";
                Bext.SetActive(false);
                selesai = true;
                //}
            }


        }

        //sampesini
    }

    public void SaveGame()
    {
        PlayerPrefs.SetInt("gold", gold);
        PlayerPrefs.SetInt("scorecap", scorecap);
        PlayerPrefs.SetInt("expcap", expcap);
        PlayerPrefs.SetInt("expget", expget);
        PlayerPrefs.SetInt("level", level);
        PlayerPrefs.SetInt("exp", exp);
        PlayerPrefs.SetInt("auto", auto);
        PlayerPrefs.SetInt("food1", food1);
        PlayerPrefs.SetInt("food1g", food1g);
        PlayerPrefs.SetInt("food2", food2);
        PlayerPrefs.SetInt("food2g", food2g);
        PlayerPrefs.SetInt("food3", food3);
        PlayerPrefs.SetInt("food3g", food3g);
        PlayerPrefs.SetInt("food4", food4);
        PlayerPrefs.SetInt("food4g", food4g);
        PlayerPrefs.SetInt("food5", food5);
        PlayerPrefs.SetInt("food5g", food5g);
        PlayerPrefs.SetInt("food6", food6);
        PlayerPrefs.SetInt("food6g", food6g);
        PlayerPrefs.SetInt("food1", food1);
        PlayerPrefs.SetInt("food1g", food1g);


        PlayerPrefs.SetInt("buildcost", buildCost);
        PlayerPrefs.SetInt("buildeff", buildEff);
        PlayerPrefs.SetInt("handcost", handCost);
        PlayerPrefs.SetInt("handeff", handEff);
        PlayerPrefs.SetInt("karyawancost", karyawanCost);
        PlayerPrefs.SetInt("karyawanEff", karyawanEff);

        
            PlayerPrefs.SetString("bosslevel", bosslevel);
            PlayerPrefs.SetString("bossbattle", bossbattle);
            PlayerPrefs.SetInt("bosscap", bosscap);
            PlayerPrefs.SetString("OndeOnde", OndeOnde);
            PlayerPrefs.SetString("KueLapis", KueLapis);
            PlayerPrefs.SetString("Putu", Putu);
            PlayerPrefs.SetString("Serabi", Serabi);
            PlayerPrefs.SetString("Bakpia", Bakpia);
            PlayerPrefs.SetInt("LevelKlepon", LevelKlepon);
            PlayerPrefs.SetInt("LevelOndeOnde", LevelOndeOnde);
            PlayerPrefs.SetInt("LevelKueLapis", LevelKueLapis);
            PlayerPrefs.SetInt("LevelPutu", LevelPutu);
            PlayerPrefs.SetInt("LevelSerabi", LevelSerabi);
            PlayerPrefs.SetInt("LevelBakpia", LevelBakpia);
            PlayerPrefs.SetInt("LevelTangan", LevelTangan);
            PlayerPrefs.SetInt("LevelGerai", LevelGerai);
            PlayerPrefs.SetInt("LevelKaryawan", LevelKaryawan);
        Debug.Log("saved");
    }


    
    public void ResetGame()
    {
        //PlayerPrefs.DeleteAll();
        //PlayerPrefs.SetInt("level", 0);
        //PlayerPrefs.SetString("bosslevel", "false");
      
        PlayerPrefs.SetInt("gold", 0);
        PlayerPrefs.SetInt("scorecap", 5);
        PlayerPrefs.SetInt("expcap", 0);
        PlayerPrefs.SetInt("expget", 30);
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.SetInt("exp", 0);
        PlayerPrefs.SetInt("auto", 0);
        PlayerPrefs.SetInt("food1", 10);
        PlayerPrefs.SetInt("food1g", 1);

        PlayerPrefs.SetInt("food2", 100);
        PlayerPrefs.SetInt("food2g", 10);

        PlayerPrefs.SetInt("food3", 5000);
        PlayerPrefs.SetInt("food3g", 150);
        PlayerPrefs.SetInt("food4", 10000);
        PlayerPrefs.SetInt("food4g", 50);
        PlayerPrefs.SetInt("food5", 10000);
        PlayerPrefs.SetInt("food5g", 50);
        PlayerPrefs.SetInt("food6", food6);
        PlayerPrefs.SetInt("food6g", food6g);


        PlayerPrefs.SetInt("buildcost", 12000);
        PlayerPrefs.SetInt("buildeff", 3000);
        PlayerPrefs.SetInt("handcost", 1000);
        PlayerPrefs.SetInt("handeff", 1);

        PlayerPrefs.SetInt("karyawancost", 1500);
        PlayerPrefs.SetInt("karyawanEff", 1);

        PlayerPrefs.SetString("bosslevel", "false");
        PlayerPrefs.SetString("bossbattle", "false");

        PlayerPrefs.SetInt("bosscap", 150);
        PlayerPrefs.SetString("OndeOnde", "false");
        PlayerPrefs.SetString("KueLapis", "false");
        PlayerPrefs.SetString("Putu", "false");
        PlayerPrefs.SetString("Serabi", "false");
        PlayerPrefs.SetString("Bakpia", "false");
        PlayerPrefs.SetInt("LevelKlepon", 1);
        PlayerPrefs.SetInt("LevelOndeOnde", 0);
        PlayerPrefs.SetInt("LevelKueLapis", 0);
        PlayerPrefs.SetInt("LevelPutu", 0);
        PlayerPrefs.SetInt("LevelSerabi", 0);
        PlayerPrefs.SetInt("LevelBakpia", 0);

        PlayerPrefs.SetInt("LevelTangan",  1);
        PlayerPrefs.SetInt("LevelGerai", 1);
        PlayerPrefs.SetInt("LevelKaryawan", 0);


        SceneManager.LoadScene(1);

    }

    private void ExitGame()
    {
        ExitMenu.SetActive(true);
    }
    public void SaveGameExit()
    {
        PlayerPrefs.SetInt("gold", gold);
        PlayerPrefs.SetInt("scorecap", scorecap);
        PlayerPrefs.SetInt("expcap", expcap);
        PlayerPrefs.SetInt("expget", expget);
        PlayerPrefs.SetInt("level", level);
        PlayerPrefs.SetInt("exp", exp);
        PlayerPrefs.SetInt("auto", auto);
        PlayerPrefs.SetInt("food1", food1);
        PlayerPrefs.SetInt("food1g", food1g);
        PlayerPrefs.SetInt("food2", food2);
        PlayerPrefs.SetInt("food2g", food2g);
        PlayerPrefs.SetInt("food3", food3);
        PlayerPrefs.SetInt("food3g", food3g);
        PlayerPrefs.SetInt("food4", food4);
        PlayerPrefs.SetInt("food4g", food4g);
        PlayerPrefs.SetInt("food5", food5);
        PlayerPrefs.SetInt("food5g", food5g);
        PlayerPrefs.SetInt("food6", food6);
        PlayerPrefs.SetInt("food6g", food6g);
        PlayerPrefs.SetInt("food1", food1);
        PlayerPrefs.SetInt("food1g", food1g);


        PlayerPrefs.SetInt("buildcost", buildCost);
        PlayerPrefs.SetInt("buildeff", buildEff);
        PlayerPrefs.SetInt("handcost", handCost);
        PlayerPrefs.SetInt("handeff", handEff);
        PlayerPrefs.SetInt("karyawancost", karyawanCost);
        PlayerPrefs.SetInt("karyawanEff", karyawanEff);


        PlayerPrefs.SetString("bosslevel", bosslevel);
        PlayerPrefs.SetString("bossbattle", bossbattle);
        PlayerPrefs.SetInt("bosscap", bosscap);
        PlayerPrefs.SetString("OndeOnde", OndeOnde);
        PlayerPrefs.SetString("KueLapis", KueLapis);
        PlayerPrefs.SetString("Putu", Putu);
        PlayerPrefs.SetString("Serabi", Serabi);
        PlayerPrefs.SetString("Bakpia", Bakpia);
        PlayerPrefs.SetInt("LevelKlepon", LevelKlepon);
        PlayerPrefs.SetInt("LevelOndeOnde", LevelOndeOnde);
        PlayerPrefs.SetInt("LevelKueLapis", LevelKueLapis);
        PlayerPrefs.SetInt("LevelPutu", LevelPutu);
        PlayerPrefs.SetInt("LevelSerabi", LevelSerabi);
        PlayerPrefs.SetInt("LevelBakpia", LevelBakpia);
        PlayerPrefs.SetInt("LevelTangan", LevelTangan);
        PlayerPrefs.SetInt("LevelGerai", LevelGerai);
        PlayerPrefs.SetInt("LevelKaryawan", LevelKaryawan);
        Debug.Log("saved");

        ExitMenu.SetActive(false);
        ExitOke.SetActive(true);
    }
}
