using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire : MonoBehaviour
{

    public GameObject gun;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Ammo.isEmpty == false)
            {
                gun_anim_fire();
            }
            else {
                gun_anim_idle();
            }
        }

        if (Input.GetButtonDown("Reload"))
        {
            gun_anim_reload();
        }
    }


    private void gun_anim_fire()
    {
        gun.GetComponent<Animation>().Play("fire");
    }

    private void gun_anim_reload()
    {
        gun.GetComponent<Animation>().Play("reload");
    }

    private void gun_anim_idle()
    {
        gun.GetComponent<Animation>().Play("idle");
    }

}