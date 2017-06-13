using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshair : MonoBehaviour {

    private Animator anim;
    public GameObject ch;
    public GameObject gun;

    private void Start()
    {
        anim = ch.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1") && gun.GetComponent<Animation>().IsPlaying("fire") == false)
        {
            anim.SetTrigger("shoot");
        }
    }

   
}
