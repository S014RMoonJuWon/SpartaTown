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
        // 캐릭터 변경 버튼
        startBtn.SetActive(false);
        characterBtn.SetActive(false);
        nameInputFieldBackground.SetActive(false);
        characterListBackground.SetActive(true);
    }

    public void ChangeConfirm()
    {
        // 캐릭터 변경 확정 버튼
        startBtn.SetActive(true);
        characterBtn.SetActive(true);
        nameInputFieldBackground.SetActive(true);
        characterListBackground.SetActive(false);
    }

    public void InGameChangeCharacter()
    {
        // 인게임 중 캐릭터 변경 - 아직 구현 못 함
    }
}