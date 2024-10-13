using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    public void gameOver()
    {
        GameManager.GetInstance().gameOver();
    }

}
