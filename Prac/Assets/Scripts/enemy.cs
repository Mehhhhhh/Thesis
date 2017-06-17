using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

    public GameObject gun;
    public int health = 10;

    public void deductpoints(int DamageAmount) {
        if (!(gun.GetComponent<Animation>().IsPlaying("fire")|| gun.GetComponent<Animation>().IsPlaying("reload"))) { 
        health = health - DamageAmount;
        }
    }

    void Update()
    {
        if (health <= 0) {
            Destroy(gameObject);
        }
    }
}
