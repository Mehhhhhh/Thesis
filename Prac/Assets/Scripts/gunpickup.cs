using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gunpickup : MonoBehaviour {

    public float distance;
    private int allowedrange;

    public GameObject display;
    public GameObject realgun;
    public GameObject holdinggun;
    public GameObject gun_mech;
    public GameObject player;

    private gun_status status;
  //  public GameObject ammoscript;

    Gunfire gf;
   // Ammo ammo;

	// Use this for initialization
	void Start () {
        distance = Playercast.distance_to_target;
        allowedrange = 3;
        gf = (Gunfire)gun_mech.GetComponent("Gunfire");
        status = player.GetComponent<gun_status>();
        //ammo = (Ammo)ammoscript.GetComponent("Ammo");
    }
	
	// Update is called once per frame
	void Update () {
        status.IsSwitching = false;
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
        else {
            display.GetComponent<Text>().text = " ";
        }
    }


    private void OnMouseExit()
    {
        display.GetComponent<Text>().text = " ";
    }


    private void pickup() {
        realgun.SetActive(true);
        this.gameObject.SetActive(false);
        holdinggun.SetActive(false);
        status.IsSwitching = true;
    }

}
