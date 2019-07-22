using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FoodButton : MonoBehaviour, IPointerClickHandler
{



    public GameObject FacilityButton;
    public GameObject FudButton;

    public void OnPointerClick(PointerEventData Z)
    {
        FacilityButton.SetActive(false);
        FudButton.SetActive(true);

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
