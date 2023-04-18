using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text scoreText;
    public int finalScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        finalScore = ScoreManager.points - 1;
        scoreText.text = "Points:" + finalScore.ToString();
    }

    // Update is called once per frame
    void Update() { }
}
