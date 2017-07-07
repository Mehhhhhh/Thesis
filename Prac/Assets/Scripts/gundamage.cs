using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gundamage : MonoBehaviour {

    public int DamageAmount = 5;
    public float TargetDistance;
    public float AllowedRange = 15;

    private gun_status status;
    private Animation anim;

    public void Start()
    {
        status = GetComponent<gun_status>();
        anim = status.get_carryinggun().GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update () {
        if (status.IsSwitching)
        {
            status.Update();
            anim = status.get_carryinggun().GetComponent<Animation>();
        }
        if (anim.IsPlaying("fire") == false && anim.IsPlaying("reload") == false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                RaycastHit shot = new RaycastHit();
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
                {
                    TargetDistance = shot.distance;
                    if (TargetDistance < AllowedRange)
                    {
                        shot.transform.SendMessage("deductpoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
                    }
                }
            }
        }

	}


}
