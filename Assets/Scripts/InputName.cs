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

        // ��ť��J�ܤơA�NOnInput���U���ƥ�B�z���A�C��nameInputField���ܭȮɴNĲ�oOnInputChanged
        nameInputField.onValueChanged.AddListener(OnInputChanged);
    }

    //�C��ȧ��ܮɴN�P�_�@��
    void OnInputChanged(string input)
    {
        UpdateButtonState();
    }

    void UpdateButtonState()
    {
        // �o�yif�����Ounity�Y�S����button���(�binspector)�N�|����
        if (confirmButton != null)
        {
            // interactable������s�i/���i�I�����A�AIsNullOrEmpty�Y�Ȭ��ūh��^true
            // �ҥH�YInputField�Ȭ��ūh���i�I��
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
        //�x�s�W�r�̫ᵲ��e���ϥ�
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