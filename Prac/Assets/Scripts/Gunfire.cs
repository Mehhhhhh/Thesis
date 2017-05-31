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
            gun_anim();

        }
    }


    private void gun_anim()
    {
        gun.GetComponent<Animation>().Play("fire");
    }


}