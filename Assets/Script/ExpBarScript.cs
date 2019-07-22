using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBarScript : MonoBehaviour
{


    Image expBar;
    float maxExp;
    public static float exp;
    // Use this for initialization
    void Start()
    {
        expBar = GetComponent<Image>();


    }

    // Update is called once per frame
    void Update()
    {
        GameObject Manager = GameObject.Find("ClickArea");
        Click otherScript = Manager.GetComponent<Click>();
        maxExp = (float)Manager.GetComponent<Click>().expcap;
        exp = (float)Manager.GetComponent<Click>().exp;

        expBar.fillAmount = exp / maxExp;

    }
}
