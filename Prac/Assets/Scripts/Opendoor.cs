using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opendoor : MonoBehaviour {

    public float distance;
    public GameObject textarea;
    public float allowed_range;

	// Use this for initialization
	void Start () {
        distance = Playercast.distance_to_target;

    }
	
	// Update is called once per frame
	void Update () {
        distance = Playercast.distance_to_target;
    }

    private void OnMouseOver()
    {
        if (distance < allowed_range) {
               textarea.GetComponent<Text>().text = "Press E to open";
        }
    }

    private void OnMouseExit()
    {
        textarea.GetComponent<Text>().text = "";
    }

}
