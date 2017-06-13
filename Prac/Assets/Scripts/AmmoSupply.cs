using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSupply : MonoBehaviour {

    public AudioSource pickupsound;

    private void OnTriggerEnter(Collider other)
    {
        pickupsound.Play();
        Ammo.totalammo += 10;
        Destroy(this.gameObject);
    }


}
