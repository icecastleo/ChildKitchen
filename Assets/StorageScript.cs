using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class StorageScript : MonoBehaviour {

    public Collider2D parent;
	public ArrayList things = new ArrayList();
    public SoundManager sm;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        //Assert.IsNotNull(parent);

        //Debug.Log("Trigger with " + other.transform.name.Split(null)[0]);

        sm.PlayStore();

        Physics2D.IgnoreCollision(parent, other);
		things.Add (other.gameObject);

		Debug.Log (things.Count);
        //other.over

        //other.transform.position = other.collider2D.
        //Destroy(other.gameObject);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //Debug.Log("Untrigger with " + other.transform.name.Split(null)[0]);

        Physics2D.IgnoreCollision(parent, other, false);
		things.Remove (other.gameObject);

		Debug.Log (things.Count);
    }
}
