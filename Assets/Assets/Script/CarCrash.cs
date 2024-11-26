using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CarCrash : MonoBehaviour
{
    public MenuUI menu;
    public GameOverController gameOverController;
    private ScoreUI scoreUI;

    // Start is called before the first frame update
    void Start()
    {
        scoreUI = FindObjectOfType<ScoreUI>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            menu.GameOver();
            gameOverController.gameOver();
            scoreUI.isGameOver = true;
        }
    }

}
