using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public GameObject player;
    public GameObject startMenu;

    public InputField nameInputField;

    public Text inputName;
    public Text inGameName;

    public void StartGame()
    {
        if ((nameInputField.text.Length >= 2) && (nameInputField.text.Length <= 10))
        {
            startMenu.SetActive(false);
            inputName.text = nameInputField.text;
            inGameName.text = inputName.text;
            player.GetComponent<TopDownMovement>().enabled = true;
        }
        else return;
    }
}