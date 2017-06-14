using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opendoor : MonoBehaviour {

    public GameObject door;
    public float distance;
    public GameObject textarea;
    private float allowed_range;

	// Use this for initialization
	void Start () {
        distance = Playercast.distance_to_target;
        allowed_range = 3;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Playercast.distance_to_target;
    }

    private void OnMouseOver()
    {
        if (distance < allowed_range) {
               textarea.GetComponent<Text>().text = "Press E to open";
               StartCoroutine(opendoor());
        }
        }

    private void OnMouseExit()
    {
        textarea.GetComponent<Text>().text = "";
    }

    private IEnumerator opendoor() {
        if (Input.GetButtonDown("Using"))
        {
            door.GetComponent<Animator>().enabled = true;
            yield return new WaitForSeconds(1f);
            door.GetComponent<Animator>().enabled = false;
            yield return new WaitForSeconds(3f);
            door.GetComponent<Animator>().enabled = true;
            yield return new WaitForSeconds(1f);
            door.GetComponent<Animator>().enabled = false;
        }
    }


}
