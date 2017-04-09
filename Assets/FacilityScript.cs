using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacilityScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D (Collider2D other)
    {
        //Debug.Log("Trigger with " + other.transform.name.Split(null)[0]);

        //other.over

        //other.transform.position = other.collider2D.
        //Destroy(other.gameObject);
    }
}
