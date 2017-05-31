using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshair : MonoBehaviour {

    private Animator anim;
    public GameObject ch;

    private void Start()
    {
        anim = ch.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("shoot");

        }
    }

   
}
