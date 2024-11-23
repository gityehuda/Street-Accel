using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuUI : MonoBehaviour
{
    public GameObject gameOverMenu;
    

    void Start()
    {
      
    }

    public void GameOver()
    {
        gameOverMenu.SetActive(true);
    }

}
