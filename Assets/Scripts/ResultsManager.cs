using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultsManager : MonoBehaviour
{
    [Header("時間顯示Text")]
    public Text currentTimeText;
    public Text easyBestText;
    public Text normalBestText;
    public Text hardBestText;
    public Text playerNameText;


    void Start()
    {
        playerNameText.text = "PLAYER：" + Global.playerName;
        DisplayTimes();
    }

    void DisplayTimes()
    {
        // 顯示本次遊戲時間
        //currentTimeText.text = "本次存活時間: " + Global.GetFormattedTime(Global.currentSurvivalTime) + " 秒";

        // 顯示各難度最佳記錄
        easyBestText.text = "EAZY: " + Global.GetFormattedTime(Global.easyBestTime);
        normalBestText.text = "MEDIUM: " + Global.GetFormattedTime(Global.normalBestTime);
        hardBestText.text = "HARD: " + Global.GetFormattedTime(Global.hardBestTime);
    }
}