using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    public bool selesai, diklik;
    public static int jujui=1;
    public float delay = 0f;
    Animator anim;
    //public GameObject Efek;

    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();
        delay += UnityEngine.Time.deltaTime;


    }
    void Awake()
    {
        Click.jujui = 1;
    }

    // Update is called once per frame
    void Update () {

        diklik = Click.diklik;
        // selesai = Click.selesai;

        /*if (Click.selesai)
        {
            //finish();
           gameObject.GetComponent<Animator>().Play("selesai");
           delay = 0;
            if (delay > 2)
            {
                Click.jujui = 2;
                Click.selesai = false;
                finish();
                gameObject.GetComponent<Animator>().Play("jembut");
            }
            
        } else if (diklik) {
            
           gameObject.GetComponent<Animator>().Play("jembut");
            Debug.Log("ikidiklik");
            Click.diklik = false;
        }*/
        if (Click.selesai)
        {
            //gameObject.GetComponent<Animator>().Play("selesai");
            gameObject.GetComponent<Animator>().SetBool("selesaix", true);
            StartCoroutine("finish");
            Click.selesai = false;
            Click.jijai = false;


        }
        else
        if (diklik)
        {
           // gameObject.GetComponent<Animator>().Play("jembut");
            gameObject.GetComponent<Animator>().SetTrigger("dikelik");
           Click.diklik = false;
        }
        
    }

    private IEnumerator finish()
    {

        
        yield return new WaitForSeconds(0.7f);
        gameObject.GetComponent<Animator>().SetBool("selesaix", false);
        Click.spawn = true;
        Click.jijai = true;
        
    }




}
