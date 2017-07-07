using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gun_status : MonoBehaviour {

    public GameObject m4;
    public GameObject g18;
    private GameObject carring_gun;
    m4_parametres m4_para;
    g18_parametres g18_para;
    public bool IsSwitching;


    // Use this for initialization
    private void Awake() { 
        m4_para = new m4_parametres();
        g18_para = new g18_parametres();
        carring_gun = m4;
        IsSwitching = false;
    }
	
	// Update is called once per frame
	public void Update () {
        if (m4.activeSelf&& (!g18.activeSelf)) {
            carring_gun = m4;
        }
        if ((!m4.activeSelf) && g18.activeSelf) {
            carring_gun = g18;
        }
	}

    public GameObject get_carryinggun() {
        return carring_gun;
    }

    public gun_parametres get_carrying_parametres() {
        if (carring_gun == m4) {
            return m4_para;
        }
       else
        {
            return g18_para;
        }
    }

    public string get_carringgun_name() {
        if (carring_gun == m4)
        {
            return "m4";
        }
        else
        {
            return "g18";
        }

    }

}
