using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScore : MonoBehaviour
{
    [SerializeField] private TMP_Text score;
    [SerializeField] private ScoreUI scoreUI;

    // Update is called once per frame
    void Update()
    {
        score.text = scoreUI.scoreText.text;
    }
}
