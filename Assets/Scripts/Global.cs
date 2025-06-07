using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global
{
    // �T�����ת��̨Φs���ɶ��O��
    public static float easyBestTime = 0f;
    public static float normalBestTime = 0f;
    public static float hardBestTime = 0f;

    // ���e�C�����s���ɶ�
    public static float currentSurvivalTime = 0f;

    // ���e��ܪ�����
    public static Difficulty currentDifficulty = Difficulty.Easy;

    // ���׵���
    public enum Difficulty
    {
        Easy,
        Normal,
        Hard
    }

    // �s���ɶ�������k
    public static void RecordSurvivalTime(Difficulty difficulty, float survivalTime)
    {
        currentSurvivalTime = survivalTime;

        switch (difficulty)
        {
            case Difficulty.Easy:
                if (survivalTime > easyBestTime)
                {
                    easyBestTime = survivalTime;
                    Debug.Log($"�s��²�����׳̨ΰO��: {easyBestTime:F2} ��");
                }
                break;
            case Difficulty.Normal:
                if (survivalTime > normalBestTime)
                {
                    normalBestTime = survivalTime;
                    Debug.Log($"�s�����q���׳̨ΰO��: {normalBestTime:F2} ��");
                }
                break;
            case Difficulty.Hard:
                if (survivalTime > hardBestTime)
                {
                    hardBestTime = survivalTime;
                    Debug.Log($"�s���x�����׳̨ΰO��: {hardBestTime:F2} ��");
                }
                break;
        }
    }

    public static float GetBestTime(Difficulty difficulty)
    {
        switch (difficulty)
        {
            case Difficulty.Easy:
                return easyBestTime;
            case Difficulty.Normal:
                return normalBestTime;
            case Difficulty.Hard:
                return hardBestTime;
            default:
                return 0f;
        }
    }

    public static string GetFormattedTime(float time)
    {
        return $"{time:F2}";
    }

    public static string playerName = "";
}