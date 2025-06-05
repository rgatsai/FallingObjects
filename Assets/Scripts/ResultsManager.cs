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
        playerNameText.text = "玩家：" + Global.playerName;
        DisplayTimes();
    }

    void DisplayTimes()
    {
        // 顯示本次遊戲時間
        //currentTimeText.text = "本次存活時間: " + Global.GetFormattedTime(Global.currentSurvivalTime) + " 秒";

        // 顯示各難度最佳記錄
        easyBestText.text = "簡單難度最佳: " + Global.GetFormattedTime(Global.easyBestTime) + " 秒";
        normalBestText.text = "普通難度最佳: " + Global.GetFormattedTime(Global.normalBestTime) + " 秒";
        hardBestText.text = "困難難度最佳: " + Global.GetFormattedTime(Global.hardBestTime) + " 秒";
    }
}