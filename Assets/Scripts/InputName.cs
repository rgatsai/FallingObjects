using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public InputField nameInputField;
    public Button confirmButton; 

    void Start()
    {
        // 初始時如果輸入框是空的，按鈕不可用
        UpdateButtonState();

        // 監聽輸入變化
        nameInputField.onValueChanged.AddListener(OnInputChanged);
    }

    void OnInputChanged(string input)
    {
        UpdateButtonState();
    }

    void UpdateButtonState()
    {
        // 只有當輸入不為空且去除空白後有內容時，按鈕才可用
        if (confirmButton != null)
        {
            confirmButton.interactable = !string.IsNullOrEmpty(nameInputField.text.Trim());
        }
    }

    public void SavePlayerName()
    {
        // 去除前後空白
        string trimmedName = nameInputField.text.Trim();

        // 檢查是否為空
        if (string.IsNullOrEmpty(trimmedName))
        {
            Debug.Log("請輸入名字！");
            return;
        }

        Global.playerName = trimmedName;
    }

    public void inputName()
    {
        // 先保存名字，再切換場景
        SavePlayerName();

        // 確認名字已保存後才切換場景
        if (!string.IsNullOrEmpty(Global.playerName))
        {
            SceneManager.LoadSceneAsync(2);
        }
    }

}