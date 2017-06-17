using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_parametres
{

    protected string gun_name;
    protected int number_of_current_ammo;
    protected int number_of_total_ammo;
    protected int number_per_clip;





    // Use this for initialization
    public gun_parametres()
    {
    }


    public string Gun_name
    {
        get
        {
            return gun_name;
        }

        set
        {
            gun_name = value;
        }
    }

    public int Number_of_current_ammo
    {
        get
        {
            return number_of_current_ammo;
        }

        set
        {
            number_of_current_ammo = value;
        }
    }

    public int Number_of_total_ammo
    {
        get
        {
            return number_of_total_ammo;
        }

        set
        {
            number_of_total_ammo = value;
        }
    }

    public int Number_per_clip
    {
        get
        {
            return number_per_clip;
        }

        set
        {
            number_per_clip = value;
        }
    }

}
