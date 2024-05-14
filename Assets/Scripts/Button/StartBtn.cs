using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public GameObject player;
    public GameObject startMenu;
    public GameObject nameMenu;
    public GameObject inGameUI;

    public InputField nameInputField;

    public Text inputName;
    public Text inGameName;
    public Text inGameUiName;

    public void StartGame()
    {
        // �̸� �ؽ�Ʈ ���̰� 2 ~ 8�� ��쿡�� ��ư�� �۵� �� ���ӳ� �̸� ����
        if ((nameInputField.text.Length >= 2) && (nameInputField.text.Length <= 10))
        {
            inputName.text = nameInputField.text;
            inGameName.text = inputName.text;
            inGameUiName.text = inputName.text;
            startMenu.SetActive(false);
            inGameUI.SetActive(true);

            player.GetComponent<TopDownMovement>().enabled = true;
        }
        else return;
    }

    public void InGameNameChange()
    {
        // �̸� ���� ��ư
        player.GetComponent<TopDownMovement>().enabled = false;

        nameMenu.SetActive(true);
    }

    public void NameChangeConfirm()
    {
        // �ΰ��� �� �̸� ���� Ȯ��
        if ((nameInputField.text.Length >= 2) && (nameInputField.text.Length <= 10))
        {
            inputName.text = nameInputField.text;
            inGameName.text = inputName.text;
            inGameUiName.text = inputName.text;

            nameMenu.SetActive(false);

            player.GetComponent<TopDownMovement>().enabled = true;

        }
        else return;
    }
}
