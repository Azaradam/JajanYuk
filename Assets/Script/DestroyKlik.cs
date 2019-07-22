using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKlik : MonoBehaviour {
    public float period = 0.0f;
    public float Death;

    // Use this for initialization
    void Start () {
        period += UnityEngine.Time.deltaTime;
        

    }

    private void Awake()
    {
        Destroy(gameObject, Death);
    }

    // Update is called once per frame
    void Update () {

        //if (period == 5f)
        //{
        //    Destroy(gameObject);
        //}

   
		
	}
}
