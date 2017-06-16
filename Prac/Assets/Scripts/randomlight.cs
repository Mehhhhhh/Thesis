using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomlight : MonoBehaviour {

    System.Random rand;

	// Use this for initialization
	void Start () {
        rand = new System.Random();
        StartCoroutine(flashing());
    }
	
	// Update is called once per frame
	void Update () {

	}


    private IEnumerator flashing() {
        while (true)
        {
            GetComponent<Light>().enabled = true;
            yield return new WaitForSeconds(rand.Next(2, 10));
            GetComponent<Light>().enabled = false;
            yield return new WaitForSeconds(rand.Next(1, 2));
        }
    }
}
