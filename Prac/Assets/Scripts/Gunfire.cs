using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire : MonoBehaviour
{

    public GameObject player;
    private Animation anim;
    public GameObject ammo;
    public GameObject muzzle;

    gun_status status;
    Ammo am;

    private void Start()
    {
        status = player.GetComponent<gun_status>();
        anim = status.get_carryinggun().GetComponent<Animation>();
        am = (Ammo)ammo.GetComponent("Ammo");
    }

    // Update is called once per frame
    public void Update()
    {
        if (status.IsSwitching) {
            anim = status.get_carryinggun().GetComponent<Animation>();
            status.IsSwitching = false;
        }
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
        if (status.get_carringgun_name() == "m4")
        {
            yield return new WaitForSeconds(0.05f);
            GameObject.Find("FPSController/FirstPersonCharacter/m4_fp/muzzleflash").SetActive(true);
            yield return new WaitForSeconds(0.1f);
            GameObject.Find("FPSController/FirstPersonCharacter/m4_fp/muzzleflash").SetActive(false);
        }
        else {
            yield return new WaitForSeconds(0.05f);
            GameObject.Find("FPSController/FirstPersonCharacter/g18_fp_real/muzzleflash").SetActive(true);
            yield return new WaitForSeconds(0.1f);
            GameObject.Find("FPSController/FirstPersonCharacter/g18_fp_real/muzzleflash").SetActive(false);
        }
    }

}