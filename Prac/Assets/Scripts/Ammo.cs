using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour {

    public int initial_total_ammo;
    public int intial_current_ammo;
    public int number_per_clip;
    private int CurrentAmmo ;
    public static int totalammo;
    public GameObject display_total;
    public GameObject display_current;
    public GameObject gun;
    public static bool isEmpty;
    public static bool isAuto_reload;
    private Animation anim;

	// Use this for initialization
	void Start () {
        totalammo = initial_total_ammo;
        CurrentAmmo = intial_current_ammo;
        anim = gun.GetComponent<Animation>();
    }
	
	// Update is called once per frame
	void Update () {
        if(totalammo <= 0 && CurrentAmmo <= 0) {
            isAuto_reload = false;
            isEmpty = true;
        }
        else
        {
            isAuto_reload = false;
            isEmpty = false;
            int diff = number_per_clip - CurrentAmmo;
            if (anim.IsPlaying("fire") == false && anim.IsPlaying("reload") == false)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                CurrentAmmo--;
                }
                if (CurrentAmmo <= 0 && totalammo != 0)
                {
                    auto_reload();
                    isAuto_reload = true;
                }
                if (Input.GetButtonDown("Reload"))
                {

                    if (diff > totalammo)
                    {
                        CurrentAmmo += totalammo;
                        totalammo = 0;
                     }
                     else
                     {
                           CurrentAmmo = number_per_clip;
                           totalammo -= diff;
                     }

                }
                display_total.GetComponent<Text>().text = "" + totalammo;
                display_current.GetComponent<Text>().text = "" + CurrentAmmo;
            }
        }
    }



    private void auto_reload() {

        int diff = number_per_clip - CurrentAmmo;

        if (diff > totalammo)
        {
            CurrentAmmo += totalammo;
            totalammo = 0;
        }
        else
        {
            CurrentAmmo += number_per_clip;
            totalammo -= number_per_clip;
        }
    }

}
