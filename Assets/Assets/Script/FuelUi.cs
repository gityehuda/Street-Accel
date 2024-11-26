using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelUi : MonoBehaviour
{
    private CarDriving cd;
    public Image fuelImage;
    public MenuUI menu;
    public GameOverController gameOverController;
    private ScoreUI scoreUI;

    void Awake()
    {
        cd = FindObjectOfType<CarDriving>();
        scoreUI = FindObjectOfType<ScoreUI>();
    }

    // Update is called once per frame
    void Update()
    {
        fuelImage.fillAmount = cd.fuel / cd.maxfuel;
        if(cd.fuel <= 0) 
        {
            menu.GameOver();
            gameOverController.gameOver();
            scoreUI.isGameOver = true;
        }
    }
}
