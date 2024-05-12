using UnityEngine;
using UnityEngine.UI;

public class CharacterListBtn : MonoBehaviour
{
    public GameObject startBtn;
    public GameObject characterBtn;
    public GameObject nameInputFieldBackground;
    public GameObject characterListBackground;

    public void ChangeCharacter()
    {
        startBtn.SetActive(false);
        characterBtn.SetActive(false);
        nameInputFieldBackground.SetActive(false);
        characterListBackground.SetActive(true);
    }

    public void ChangeConfirm()
    {
        startBtn.SetActive(true);
        characterBtn.SetActive(true);
        nameInputFieldBackground.SetActive(true);
        characterListBackground.SetActive(false);
    }
}