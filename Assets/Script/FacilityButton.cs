using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FacilityButton : MonoBehaviour, IPointerClickHandler{



    public GameObject FasilitiButton;
    public GameObject FoodButton;

    public void OnPointerClick(PointerEventData Z)
    {
        FasilitiButton.SetActive(true);
        FoodButton.SetActive(false);

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
}
