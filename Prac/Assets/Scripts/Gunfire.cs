using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire : MonoBehaviour
{

    public GameObject player;
    public GameObject fire;
    private Animation anim;
    public GameObject ammo;
    gun_status status;
    Ammo am;

    private void Start()
    {
        status = player.GetComponent<gun_status>();
        anim = status.get_carryinggun().GetComponent<Animation>();
        am = (Ammo)ammo.GetComponent("Ammo");
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

        if (Input.GetButtonDown("Reload") && anim.IsPlaying("fire") == false && am.getTotalammo() != 0)
        {
            gun_anim_reload();
        }
    }


    private void gun_anim_fire()
    {
        status.get_carryinggun().GetComponent<Animation>()["fire"].speed = 2.0f;
        if (!status.get_carryinggun().GetComponent<Animation>().IsPlaying("fire"))
        {
            StartCoroutine(play_muzzleflash());
        }
        status.get_carryinggun().GetComponent<Animation>().Play("fire");
       
    }

    private void gun_anim_reload()
    {
        status.get_carryinggun().GetComponent<Animation>()["fire"].speed = 2.0f;
        status.get_carryinggun().GetComponent<Animation>().Play("reload");
    }

    private void gun_anim_idle()
    {
        status.get_carryinggun().GetComponent<Animation>().Play("idle");
    }

    private IEnumerator play_muzzleflash() {
        yield return new WaitForSeconds(0.05f);
        fire.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        fire.SetActive(false) ;
    }

}