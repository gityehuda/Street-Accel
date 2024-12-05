using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    private MenuUI menu;
    private GameOverController gameOverController;
    private static GameManager instance;
    public ScoreUI scoreUI;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static GameManager GetInstance()
    {
        return instance;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOverController = GetComponent<GameOverController>();
        menu = GetComponent<MenuUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        menu.GameOver();
        gameOverController.gameOver();
    }

    public void Score()
    {
        scoreUI.isGameOver = true;
    }

}
