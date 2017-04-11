using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RefrigeratorScript : MonoBehaviour, IPointerClickHandler {

	public Sprite open;
	public Sprite close;

	bool isOpen = false;

	private ArrayList temp = new ArrayList();
    public SoundManager sm;

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
            sm.PlayFridgeClose();
            gameObject.GetComponent<SpriteRenderer> ().sprite = close;

			foreach(GameObject g in transform.GetComponentInChildren<StorageScript>().things) {
				temp.Add (g);
			}

			foreach(GameObject g in temp) {
				g.SetActive (false);
			}
				
			transform.FindChild("storage").gameObject.SetActive(false);

		} else {
            // Debug.Log ("Open");
            sm.PlayFridgeOpen();
            isOpen = true;
			gameObject.GetComponent<SpriteRenderer> ().sprite = open;
			transform.FindChild("storage").gameObject.SetActive(true);

			foreach(GameObject g in temp) {
				g.SetActive (true);
			}
			temp.Clear ();
		}
	}
}