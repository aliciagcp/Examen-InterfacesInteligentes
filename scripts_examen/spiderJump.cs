using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class spiderJump : MonoBehaviour
{
    Notifier ghoul;
    private int score = 0;
    TextMeshProUGUI scoreText;
 
    void Start()
    {
        ghoul = GameObject.Find("Ghoul").GetComponent<Notifier>();
        scoreText = GameObject.Find("Canvas/score").GetComponent<TextMeshProUGUI>();
        ghoul.OnJump += UpdateScore;
    }
 
    private void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}
