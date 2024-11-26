using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TMP_Text text;
    int score;
    public bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        score = 0;
        InvokeRepeating("ScoreUpdate", 0.1f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
        
    }

    void ScoreUpdate()
    {
        if(!isGameOver)
        {
            score += 1;
        }
        
    }

}
