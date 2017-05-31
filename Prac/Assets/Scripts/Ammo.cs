using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour {

    public static int CurrentAmmo ;
    private int internalAmmo;
    public GameObject display;

	// Use this for initialization
	void Start () {
        CurrentAmmo = 20;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            CurrentAmmo--;
        }
        internalAmmo = CurrentAmmo;
        display.GetComponent<Text>().text ="" + internalAmmo ;

	}
}
