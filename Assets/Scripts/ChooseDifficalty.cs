using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChooseDifficalty: MonoBehaviour
{
    public void chooseEasy()
    {
        Global.currentDifficulty = Global.Difficulty.Easy;
        SceneManager.LoadSceneAsync(3);
    }

    public void chooseMedium()
    {
        Global.currentDifficulty = Global.Difficulty.Normal;
        SceneManager.LoadSceneAsync(4);
    }

    public void chooseDifficult() 
    {
        Global.currentDifficulty = Global.Difficulty.Hard;
        SceneManager.LoadSceneAsync(5);
    }

    public void goMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void goEnd()
    {
        SceneManager.LoadSceneAsync(6);
    }
}
