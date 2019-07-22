using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UpgradePanel : MonoBehaviour,IPointerClickHandler {

    public Animator Anim;
    private bool Cond = true;
    public GameObject TamengAntiKlikKlikBiarGaErrorClub;

    public void OnPointerClick (PointerEventData Z)
    {
        Debug.Log(name);
        
            if (Cond)
            {
                //Debug.Log(name);
                Anim.Play("AnimasiUp");
                Cond = false;
            TamengAntiKlikKlikBiarGaErrorClub.SetActive(true);
            }
            else
            {
                Debug.Log(name);
                Anim.Play("AnimasiDown");
                Cond = true;
            TamengAntiKlikKlikBiarGaErrorClub.SetActive(false);
            }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
