using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice_damage2 : MonoBehaviour {

    public practice_score practice_scripts;

    public void Start()
    {
        practice_scripts = GameObject.Find("practice/Practice_score").GetComponent<practice_score>();
    }

    public void deductpoints(int DamageAmount)
    {
            practice_scripts.setScore(practice_scripts.getScore() + 75);
    }
}
