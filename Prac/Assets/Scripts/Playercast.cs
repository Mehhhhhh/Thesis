using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercast : MonoBehaviour
    {

        public static float distance_to_target;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                distance_to_target = hit.distance;
            }
        }
    }
