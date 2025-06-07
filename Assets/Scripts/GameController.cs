using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    public Canvas GameOverCanvas;
    public TMP_Text TimerText;

    private void Awake()
    {
        if(playerController != null)
        {   //當玩家死亡時，自動調用WhenPlayerDies
            playerController.PlayerDied += WhenPlayerDies;
        }
            //確保遊戲加載時不會顯示GameOver畫面
        if (GameOverCanvas.gameObject.activeSelf)
        {
            GameOverCanvas.gameObject.SetActive(false);
        }
    }

    void WhenPlayerDies()
    {   //當玩家死亡時出現GameOver，並讀取場景加載時間=玩家存活時間
        GameOverCanvas.gameObject.SetActive(true);
        float survivalTime = (float)Math.Round(Time.timeSinceLevelLoad, 2);
        TimerText.text = "You Lasted:" + survivalTime;
        //將存活時間和難度傳送給全域變數
        TimerText.text = "Survival " + survivalTime;

        Global.RecordSurvivalTime(Global.currentDifficulty, survivalTime);
        //防止死亡後重新執行
        if (playerController != null)
        {   
            playerController.PlayerDied -= WhenPlayerDies;
        }
    }

    //給Retry按鈕使用，重新加載場景
    public void RetryClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
