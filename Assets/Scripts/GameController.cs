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
        {   //���a���`�ɡA�۰ʽե�WhenPlayerDies
            playerController.PlayerDied += WhenPlayerDies;
        }
            //�T�O�C���[���ɤ��|���GameOver�e��
        if (GameOverCanvas.gameObject.activeSelf)
        {
            GameOverCanvas.gameObject.SetActive(false);
        }
    }

    void WhenPlayerDies()
    {   //���a���`�ɥX�{GameOver�A��Ū�������[���ɶ�=���a�s���ɶ�
        GameOverCanvas.gameObject.SetActive(true);
        float survivalTime = (float)Math.Round(Time.timeSinceLevelLoad, 2);
        TimerText.text = "You Lasted:" + survivalTime;
        //�N�s���ɶ��M���׶ǰe�������ܼ�
        TimerText.text = "Survival " + survivalTime;

        Global.RecordSurvivalTime(Global.currentDifficulty, survivalTime);
        //����`�᭫�s����
        if (playerController != null)
        {   
            playerController.PlayerDied -= WhenPlayerDies;
        }
    }

    //��Retry���s�ϥΡA���s�[������
    public void RetryClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
