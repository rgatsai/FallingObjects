using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global
{
    // 三個難度的最佳存活時間記錄
    public static float easyBestTime = 0f;
    public static float normalBestTime = 0f;
    public static float hardBestTime = 0f;

    // 當前遊戲的存活時間
    public static float currentSurvivalTime = 0f;

    // 當前選擇的難度
    public static Difficulty currentDifficulty = Difficulty.Easy;

    // 難度等級
    public enum Difficulty
    {
        Easy,
        Normal,
        Hard
    }

    // 存活時間相關方法
    public static void RecordSurvivalTime(Difficulty difficulty, float survivalTime)
    {
        currentSurvivalTime = survivalTime;

        switch (difficulty)
        {
            case Difficulty.Easy:
                if (survivalTime > easyBestTime)
                {
                    easyBestTime = survivalTime;
                    Debug.Log($"新的簡單難度最佳記錄: {easyBestTime:F2} 秒");
                }
                break;
            case Difficulty.Normal:
                if (survivalTime > normalBestTime)
                {
                    normalBestTime = survivalTime;
                    Debug.Log($"新的普通難度最佳記錄: {normalBestTime:F2} 秒");
                }
                break;
            case Difficulty.Hard:
                if (survivalTime > hardBestTime)
                {
                    hardBestTime = survivalTime;
                    Debug.Log($"新的困難難度最佳記錄: {hardBestTime:F2} 秒");
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