using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private ScoreUI score;
    private float speed = 21;

    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<ScoreUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (score.score >= 500 && score.score <= 800) 
        {
            speed = 24;
        }
        if (score.score > 800)
        {
            speed = 31;
        }
   
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);

    }
}
