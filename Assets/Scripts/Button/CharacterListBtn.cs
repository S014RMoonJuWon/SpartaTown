using UnityEngine;
using UnityEngine.UI;

public class CharacterListBtn : MonoBehaviour
{
    public GameObject startBtn;
    public GameObject characterBtn;
    public GameObject nameInputFieldBackground;
    public GameObject characterListBackground;
    public GameObject player;

    public SpriteRenderer characterRenderer1;
    public SpriteRenderer characterRenderer2;

    public Image characterImage;
    public Image characterImage1;
    public Image characterImage2;

    private void Start()
    {
        characterRenderer1 = GetComponent<SpriteRenderer>();
        characterRenderer2 = GetComponent<SpriteRenderer>();

        characterImage = GetComponent<Image>();
        characterImage1 = GetComponent<Image>();
        characterImage2 = GetComponent<Image>();
    }

    public void ChangeCharacter()
    {
        startBtn.SetActive(false);
        characterBtn.SetActive(false);
        nameInputFieldBackground.SetActive(false);
        characterListBackground.SetActive(true);
    }

    public void SelectCharater1()
    {
        startBtn.SetActive(true);
        characterBtn.SetActive(true);
        nameInputFieldBackground.SetActive(true);
        characterListBackground.SetActive(false);

        characterImage.sprite = characterImage1.sprite;

        player.GetComponent<SpriteRenderer>().sprite = characterRenderer1.sprite;
    }

    public void SelectCharater2()
    {
        startBtn.SetActive(true);
        characterBtn.SetActive(true);
        nameInputFieldBackground.SetActive(true);
        characterListBackground.SetActive(false);

        characterImage.sprite = characterImage2.sprite;

        player.GetComponent<SpriteRenderer>().sprite = characterRenderer2.sprite;
    }
}