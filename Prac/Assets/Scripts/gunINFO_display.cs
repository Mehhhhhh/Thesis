using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gunINFO_display : MonoBehaviour {

    public GameObject displayarea;
    public GameObject player;

    gun_status status;
    Text t;

	// Use this for initialization
	void Start () {
        t = displayarea.GetComponent<Text>();
        status = player.GetComponent<gun_status>();
	}
	
	// Update is called once per frame
	void Update () {
        t.text = status.get_carrying_parametres().Gun_name;
	}
}
