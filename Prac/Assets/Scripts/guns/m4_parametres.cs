using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m4_parametres : gun_parametres {

    public m4_parametres()
    {
        gun_name = "m4";
        number_of_current_ammo = 10;
        number_of_total_ammo = 30;
        number_per_clip = 10;
    }
}
