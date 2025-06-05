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


    void Start()
    {
        playerNameText.text = "���a�G" + Global.playerName;
        DisplayTimes();
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
}