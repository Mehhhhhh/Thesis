using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class practice_score : MonoBehaviour {

    private int score;
    public GameObject scoredisplay;

    private void Start()
    {
        score = 0;
    }

    public void setScore(int score) {
        this.score = score;
    }

    public int getScore()
    {
        return score;
    }


    private void Update()
    {
        scoredisplay.GetComponent<Text>().text = "" + score;
    }

}
