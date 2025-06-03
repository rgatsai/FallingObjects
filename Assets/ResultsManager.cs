using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultsManager : MonoBehaviour
{
    [Header("�ɶ����Text")]
    public Text currentTimeText;
    public Text easyBestText;
    public Text normalBestText;
    public Text hardBestText;
    public Text playerNameText;

    [Header("���s")]
    public Button restartButton;
    public Button mainMenuButton;

    void Start()
    {
        playerNameText.text = "���a�G" + Global.playerName;
        DisplayTimes();
        SetupButtons();
    }

    void DisplayTimes()
    {
        // ��ܥ����C���ɶ�
        //currentTimeText.text = "�����s���ɶ�: " + Global.GetFormattedTime(Global.currentSurvivalTime) + " ��";

        // ��ܦU���׳̨ΰO��
        easyBestText.text = "²�����׳̨�: " + Global.GetFormattedTime(Global.easyBestTime) + " ��";
        normalBestText.text = "���q���׳̨�: " + Global.GetFormattedTime(Global.normalBestTime) + " ��";
        hardBestText.text = "�x�����׳̨�: " + Global.GetFormattedTime(Global.hardBestTime) + " ��";
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
        // ���s���J�W�@�ӳ����A�Ϋ��w����
        SceneManager.LoadSceneAsync(2);
    }
    public void GoToMainMenu()
    {
        // ���J�D������
        SceneManager.LoadSceneAsync(0); // �������A���D���Scene�W��
    }
}