using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WindowScript : MonoBehaviour, IPointerClickHandler
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("click");

        GameObject rod = transform.FindChild("FishingRod").gameObject;

        Debug.Log(rod);

        if(rod.activeSelf == false)
        {
            rod.SetActive(true);
        }
    }
}
