using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercast : MonoBehaviour
    {

        public static float distance_to_target;
        private string target;
        private LayerMask layermask;

        // Use this for initialization
        void Start()
        {
            layermask = 7;
        }

        // Update is called once per frame
        void Update()
        {
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, layermask))
            {
                distance_to_target = hit.distance;
                target = hit.transform.name;
            }
        }

    public string get_targetname() {
        return target;
    }

    }
