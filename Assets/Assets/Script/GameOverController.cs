using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{

    public void gameOver()
    {
        Invoke("SceneChange", 2f);
    }

    void SceneChange()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
