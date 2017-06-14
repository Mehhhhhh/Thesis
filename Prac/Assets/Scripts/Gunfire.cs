using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire : MonoBehaviour
{

    public GameObject gun;
    public GameObject fire;
    private Animation anim;

    private void Start()
    {
        anim = gun.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")&&anim.IsPlaying("reload") == false)
        {
            if (Ammo.isEmpty == false)
            {
              gun_anim_fire();
            }
            else {
                gun_anim_idle();
            }
        }

        if (Ammo.isAuto_reload == true) {
            gun_anim_reload();
        }

        if (Input.GetButtonDown("Reload") && anim.IsPlaying("fire") == false && Ammo.totalammo != 0)
        {
            gun_anim_reload();
        }
    }


    private void gun_anim_fire()
    {
        gun.GetComponent<Animation>()["fire"].speed = 2.0f;
        if (!gun.GetComponent<Animation>().IsPlaying("fire"))
        {
            StartCoroutine(play_muzzleflash());
        }
        gun.GetComponent<Animation>().Play("fire");
       
    }

    private void gun_anim_reload()
    {
        gun.GetComponent<Animation>()["fire"].speed = 2.0f;
        gun.GetComponent<Animation>().Play("reload");
    }

    private void gun_anim_idle()
    {
        gun.GetComponent<Animation>().Play("idle");
    }

    private IEnumerator play_muzzleflash() {
        yield return new WaitForSeconds(0.05f);
        fire.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        fire.SetActive(false) ;
    }

}