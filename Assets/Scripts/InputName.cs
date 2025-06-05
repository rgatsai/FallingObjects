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
        // ��l�ɦp�G��J�جO�Ū��A���s���i��
        UpdateButtonState();

        // ��ť��J�ܤ�
        nameInputField.onValueChanged.AddListener(OnInputChanged);
    }

    void OnInputChanged(string input)
    {
        UpdateButtonState();
    }

    void UpdateButtonState()
    {
        // �u�����J�����ťB�h���ťիᦳ���e�ɡA���s�~�i��
        if (confirmButton != null)
        {
            confirmButton.interactable = !string.IsNullOrEmpty(nameInputField.text.Trim());
        }
    }

    public void SavePlayerName()
    {
        // �h���e��ť�
        string trimmedName = nameInputField.text.Trim();

        // �ˬd�O�_����
        if (string.IsNullOrEmpty(trimmedName))
        {
            Debug.Log("�п�J�W�r�I");
            return;
        }

        Global.playerName = trimmedName;
    }

    public void inputName()
    {
        // ���O�s�W�r�A�A��������
        SavePlayerName();

        // �T�{�W�r�w�O�s��~��������
        if (!string.IsNullOrEmpty(Global.playerName))
        {
            SceneManager.LoadSceneAsync(2);
        }
    }

}