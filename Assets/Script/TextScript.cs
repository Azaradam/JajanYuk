using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {


    public GameObject Manager;

    public Text Gold;
    private float emas;
    public string goldtext;

    public Text Exp;
    private float exp;
    private float expcap;
    public string exptext;

    public Text Serving;
    private float serving;
    private float servingcap;
    public string servingtext;

    public Text Level;
    private float level;
    public string leveltext;

    public Text Food1;
    private float food1;
    public string food1text;

    public Text Food2;
    private float food2;

    public Text Food3;
    private float food3;

    public Text Food4;
    private float food4;

    public Text Food5;
    private float food5;

    public Text Food6;
    private float food6;

    public Text Building;
    private float building;

    public Text Auto;
    private float auto;

    public Text Hand;
    private float hand;

    public Text Boss;
    private float boss;

    public GameObject ngeboss;

    public GameObject tombolboss;

    
    public Text LevelKlepon;
    private float lvklepon;

    public Text LevelOndeOnde;
    private float lvondeonde;

    public Text LevelKueLapis;
    private float lvkuelapis;

    public Text LevelPutu;
    private float lvputu;

    public Text LevelSerabi;
    private float lvserabi;

    public Text LevelBakpia;
    private float lvbakpia;

    public Text LevelTangan;
    private float lvtangan;

    public Text LevelKaryawan;
    private float lvkaryawan;

    public Text LevelGerai;
    private float lvgerai;

    public Text ServeSpeed;
    private float servespeed;

    public Text EmployeeSpeed;
    private float employeespeed;



    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        

        emas = (float) Manager.GetComponent<Click>().gold;
        Gold.text = goldtext + " : " + emas;

        exp = (float)Manager.GetComponent<Click>().exp;
        expcap = (float)Manager.GetComponent<Click>().expcap;
        Exp.text = exptext + " : " + exp + " / " + expcap;

        serving = (float)Manager.GetComponent<Click>().score;
        servingcap = (float)Manager.GetComponent<Click>().scorecap;
        Serving.text = servingtext + " : " + serving + " / " + servingcap;




        level = (float)Click.level;
        Level.text = leveltext + " : " + level;

        food1 = (float)Click.food1;
        Food1.text = food1text + " : " + food1;

        food2 = (float)Click.food2;
        Food2.text = food1text + " : " + food2;

        food3 = (float)Click.food3;
        Food3.text = food1text + " : " + food3;

        food4 = (float)Click.food4;
        Food4.text = food1text + " : " + food4;

        food5 = (float)Click.food5;
        Food5.text = food1text + " : " + food5;

        food6 = (float)Click.food6;
        Food6.text = food1text + " : " + food6;

        building = (float)Manager.GetComponent<Click>().buildCost;
        Building.text = food1text + " : " + building;

        auto = (float)Manager.GetComponent<Click>().karyawanCost;
        Auto.text = food1text + " : " + auto;

        hand = (float)Manager.GetComponent<Click>().handCost;
        Hand.text = food1text + " : " + hand;

        boss = (float)Manager.GetComponent<Click>().bosstime;
        Boss.text = boss.ToString("F2");

        servespeed = (float)Manager.GetComponent<Click>().damage;
        ServeSpeed.text = ":  " + servespeed;

        employeespeed = (float)Manager.GetComponent<Click>().auto;
        EmployeeSpeed.text = ":  " + employeespeed;

        //--------------------------------------------------------------

        lvklepon = (float)Manager.GetComponent<Click>().LevelKlepon;
        LevelKlepon.text = "Lv" + lvklepon;

        lvondeonde = (float)Manager.GetComponent<Click>().LevelOndeOnde;
        LevelOndeOnde.text = "Lv" + lvondeonde;

        lvkuelapis = (float)Manager.GetComponent<Click>().LevelKueLapis;
        LevelKueLapis.text = "Lv" + lvkuelapis;

        lvputu = (float)Manager.GetComponent<Click>().LevelPutu;
        LevelPutu.text = "Lv" + lvputu;

        lvserabi = (float)Manager.GetComponent<Click>().LevelSerabi;
        LevelSerabi.text = "Lv" + lvserabi;

        lvbakpia = (float)Manager.GetComponent<Click>().LevelBakpia;
        LevelBakpia.text = "Lv" + lvbakpia;


        lvtangan = (float)Manager.GetComponent<Click>().LevelTangan;
        LevelTangan.text = "Lv" + lvtangan;

        lvkaryawan = (float)Manager.GetComponent<Click>().LevelKaryawan;
        LevelKaryawan.text = "Lv" + lvkaryawan;

        lvgerai = (float)Manager.GetComponent<Click>().LevelGerai;
        LevelGerai.text = "Lv" + lvgerai;

    }
}
