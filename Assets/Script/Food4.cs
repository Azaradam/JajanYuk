using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food4 : MonoBehaviour
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
        GameObject Manager = GameObject.Find("ClickArea");
        Click otherScript = Manager.GetComponent<Click>();
        otherScript.Food4();
    }

}
