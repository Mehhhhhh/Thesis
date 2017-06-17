using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gunpickup : MonoBehaviour {

    public float distance;
    public GameObject display;
    private int allowedrange;
    public GameObject realgun;
    public GameObject holdinggun;

	// Use this for initialization
	void Start () {
        distance = Playercast.distance_to_target;
        allowedrange = 2;
    }
	
	// Update is called once per frame
	void Update () {
        distance = Playercast.distance_to_target;
        if (distance < allowedrange) {
            if (Input.GetButtonDown("Using"))
            {
                pickup();
            }
        }
	}

    private void OnMouseOver()
    {
        if (distance < allowedrange)
        {
            display.GetComponent<Text>().text = " Pick up g18";
        }
    }

    private void OnMouseExit()
    {
        display.GetComponent<Text>().text = "";
    }


    private void pickup() {
        realgun.SetActive(true);
        GetComponent<GameObject>().SetActive(false);
        holdinggun.SetActive(false);
    }

}
