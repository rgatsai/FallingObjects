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

        // 監聽輸入變化，將OnInput註冊為事件處理器，每當nameInputField改變值時就觸發OnInputChanged
        nameInputField.onValueChanged.AddListener(OnInputChanged);
    }

    //每當值改變時就判斷一次
    void OnInputChanged(string input)
    {
        UpdateButtonState();
    }

    void UpdateButtonState()
    {
        // 這句if指的是unity若沒有為button賦值(在inspector)就會報錯
        if (confirmButton != null)
        {
            // interactable控制按鈕可/不可點擊狀態，IsNullOrEmpty若值為空則返回true
            // 所以若InputField值為空則不可點擊
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
        //儲存名字最後結算畫面使用
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