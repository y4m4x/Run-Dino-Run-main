using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text scoreText;
    public float scoreNumber;
    public float scoreSuma;



    void Start()
    {
        scoreNumber = 0;
        scoreSuma = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + (int)scoreNumber;
        scoreNumber+=scoreSuma * Time.deltaTime;
    }
}
