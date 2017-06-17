using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m4 : MonoBehaviour {

    gun_parametres weapon;
    public GameObject dispaly;
	// Use this for initialization
	void Start () {
        weapon = new m4_parametres();
        Ammo ammo = dispaly.GetComponent<Ammo>();
        ammo.initial_total_ammo = weapon.Number_of_total_ammo;
        ammo.intial_current_ammo = weapon.Number_of_current_ammo;
        ammo.number_per_clip = weapon.Number_per_clip;

	}
	
	// Update is called once per frame
	void Update () {
	}
}
