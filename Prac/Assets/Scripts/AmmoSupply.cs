using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSupply : MonoBehaviour {

    public AudioSource pickupsound;
    public GameObject ammo_script;
    Ammo am;

    private void Start()
    {
        am = (Ammo)ammo_script.GetComponent("Ammo");
    }

    private void OnTriggerEnter(Collider other)
    {
        pickupsound.Play();
        am.setTotalammo(am.getTotalammo()+10);
        Destroy(this.gameObject);
    }


}
