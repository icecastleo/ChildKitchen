using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacilityScript : MonoBehaviour {

    struct Pair
    {
        public string facility, item;

        public Pair(string f, string i)
        {
            facility = f;
            item = i;
        }
    }

    Dictionary<Pair, float> points;

    // Use this for initialization
    void Start () {
        points = new Dictionary<Pair, float>();

        points.Add(new Pair("TrashCan", "trash0"), 2);
        points.Add(new Pair("TrashCan", "trash2"), 4);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D (Collider2D other)
    {
        Pair p = new Pair(gameObject.name, other.gameObject.name.Split(new char[] {'('})[0]);

        if(points.ContainsKey(p))
        {
            Debug.Log("Gain point : " + points[p]);
            Destroy(other.gameObject);
        }
    }
}
