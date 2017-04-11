using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RefrigeratorScript : MonoBehaviour, IPointerClickHandler {

	public Sprite open;
	public Sprite close;

	bool isOpen = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnPointerClick(PointerEventData eventData)
	{
		if (isOpen) {
			isOpen = false;
			gameObject.GetComponent<SpriteRenderer> ().sprite = close;
			transform.FindChild("storage").gameObject.SetActive(false);
		} else {
			// Debug.Log ("Open");
			isOpen = true;
			gameObject.GetComponent<SpriteRenderer> ().sprite = open;
			transform.FindChild("storage").gameObject.SetActive(true);
		}
	}
}