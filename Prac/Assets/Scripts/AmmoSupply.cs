using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSupply : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        Ammo.CurrentAmmo += 10;
    }

}
