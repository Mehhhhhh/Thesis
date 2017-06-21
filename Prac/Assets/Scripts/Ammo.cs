using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour {

    private int number_per_clip;
    private int CurrentAmmo ;
    private int totalammo;
    public GameObject display_total;
    public GameObject display_current;
    public GameObject player;
    private gun_status status;
    public static bool isEmpty;
    public static bool isAuto_reload;
    private Animation anim;
    private gun_parametres gun;
	// Use this for initialization
	void Start () {
        status = player.GetComponent<gun_status>();
        gun = status.get_carrying_parametres();
        totalammo = gun.Number_of_total_ammo;
        CurrentAmmo = gun.Number_of_current_ammo;
        number_per_clip = gun.Number_per_clip;
        anim = status.get_carryinggun().GetComponent<Animation>();
    }
	
	// Update is called once per frame
	void Update () {
        if (status.IsSwitching) {
            status.Update();
            gun = status.get_carrying_parametres();
            totalammo = gun.Number_of_total_ammo;
            CurrentAmmo = gun.Number_of_current_ammo;
            number_per_clip = gun.Number_per_clip;
            anim = status.get_carryinggun().GetComponent<Animation>();
        }
        if (totalammo <= 0 && CurrentAmmo <= 0) {
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

    public void setTotalammo(int ammo) {
        totalammo = ammo;
    }

    public int getTotalammo() {
        return totalammo;
    }

}
