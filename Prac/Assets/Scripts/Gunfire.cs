using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire : MonoBehaviour
{
    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            gun_anim();
            crosshair_anim();

        }
    }


    void gun_anim()
    {
        GetComponent<Animation>().Play("fire");
    }

    IEnumerator crosshair_anim()
    {
        up.GetComponent<Animator>().enabled = true;
        down.GetComponent<Animator>().enabled = true;
        left.GetComponent<Animator>().enabled = true;
        right.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds((float)0.1);
        up.GetComponent<Animator>().enabled = false;
        down.GetComponent<Animator>().enabled = false;
        left.GetComponent<Animator>().enabled = false;
        right.GetComponent<Animator>().enabled = false;
    }
}