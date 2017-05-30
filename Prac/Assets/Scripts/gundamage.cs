using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gundamage : MonoBehaviour {

    public int DamageAmount = 5;
    public float TargetDistance;
    public float AllowedRange = 15;

	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            RaycastHit shot = new RaycastHit();
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot)) {
                TargetDistance = shot.distance;
                if (TargetDistance < AllowedRange) {
                    shot.transform.SendMessage("deductpoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
	}
}
