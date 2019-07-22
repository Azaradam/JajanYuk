using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelBoss : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Upgrade()
    {
        if (Click.jijai)
        {
            GameObject Manager = GameObject.Find("ClickArea");
            Click otherScript = Manager.GetComponent<Click>();
            otherScript.CancelBoss();
            otherScript.tombolboss.SetActive(true);
        }
    }

}
