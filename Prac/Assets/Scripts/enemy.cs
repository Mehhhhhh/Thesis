using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    public int health = 10;

    public void deductpoints(int DamageAmount) {
        health = health - DamageAmount;
    }

    void Update()
    {
        if (health <= 0) {
            Destroy(gameObject);
        }
    }
}
