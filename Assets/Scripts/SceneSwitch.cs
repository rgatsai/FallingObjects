using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void goMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void backChooseDifficult()
    {
        SceneManager.LoadSceneAsync(2);
    }


    public void chooseEasy()
    {
        Global.currentDifficulty = Global.Difficulty.Easy;
        SceneManager.LoadSceneAsync(3);
    }

    public void chooseNormal()
    {
        Global.currentDifficulty = Global.Difficulty.Normal;
        SceneManager.LoadSceneAsync(4);
    }

    public void chooseHard()
    {
        Global.currentDifficulty = Global.Difficulty.Hard;
        SceneManager.LoadSceneAsync(5);
    }

    public void goEnd()
    {
        SceneManager.LoadSceneAsync(6);
    }
}
