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
    public SoundManager sm;

    // Use this for initialization
    void Start () {
        points = new Dictionary<Pair, float>();

        points.Add(new Pair("TrashCan", "trash0"), 3);
        points.Add(new Pair("TrashCan", "trash2"), 4);
        points.Add(new Pair("pot", "puffer fish"), 3);
        points.Add(new Pair("pot", "salmon"), 3);

	    points.Add(new Pair("drawer1", "puffer fish"), 0);
        points.Add(new Pair("drawer1", "salmon"), 0);
		points.Add(new Pair("drawer1", "trash0"), 0);
		points.Add(new Pair("drawer1", "trash2"), 0);
        points.Add(new Pair("drawer2", "puffer fish"), 0);
        points.Add(new Pair("drawer2", "salmon"), 0);
		points.Add(new Pair("drawer2", "trash0"), 0);
		points.Add(new Pair("drawer2", "trash2"), 0);
        points.Add(new Pair("drawer3", "puffer fish"), 0);
        points.Add(new Pair("drawer3", "salmon"), 0);
		points.Add(new Pair("drawer3", "trash0"), 0);
		points.Add(new Pair("drawer3", "trash2"), 0);
        points.Add(new Pair("drawer4", "puffer fish"), 0);
        points.Add(new Pair("drawer4", "salmon"), 0);
		points.Add(new Pair("drawer4", "trash0"), 0);
		points.Add(new Pair("drawer4", "trash2"), 0);

		points.Add(new Pair("tank", "puffer fish"), 2);
        points.Add(new Pair("tank", "salmon"), 2);
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

			if (gameObject.name.StartsWith ("drawer")) {
				sm.PlayNegative2 ();
			} else {
				sm.PlayPositive ();
			}
        }
        else
        {
            sm.PlayNegative2();
        }
    }
}
