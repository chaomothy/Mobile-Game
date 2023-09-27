using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;
    public float scoreValue = 0f;
    public float pointsIncreasedPerSecond = 1f;


    void FixedUpdate()
    {
        
        scoreText.text = ((int)scoreValue).ToString();
        scoreValue += pointsIncreasedPerSecond * Time.fixedDeltaTime;


    }
}
