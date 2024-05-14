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
        // 이름 텍스트 길이가 2 ~ 8일 경우에만 버튼이 작동 및 게임내 이름 변경
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
        // 이름 변경 버튼
        player.GetComponent<TopDownMovement>().enabled = false;

        nameMenu.SetActive(true);
    }

    public void NameChangeConfirm()
    {
        // 인게임 중 이름 변경 확정
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
