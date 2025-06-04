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

    [Header("按鈕")]
    public Button restartButton;
    public Button mainMenuButton;

    void Start()
    {
        playerNameText.text = "玩家：" + Global.playerName;
        DisplayTimes();
        SetupButtons();
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

    void SetupButtons()
    {
        if (restartButton != null)
            restartButton.onClick.AddListener(RestartGame);

        if (mainMenuButton != null)
            mainMenuButton.onClick.AddListener(GoToMainMenu);
    }

    public void RestartGame()
    {
        // 重新載入上一個場景，或指定場景
        SceneManager.LoadSceneAsync(2);
    }
    public void GoToMainMenu()
    {
        // 載入主選單場景
        SceneManager.LoadSceneAsync(0); // 替換成你的主選單Scene名稱
    }
}