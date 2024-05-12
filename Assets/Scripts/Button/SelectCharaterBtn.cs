using UnityEngine;
using UnityEngine.UI;

public class SelectCharaterBtn : MonoBehaviour
{
    public GameObject player;
    public GameObject characterBtnImage;
    public GameObject characterRenderer1;
    public GameObject characterRenderer2;

    public Sprite characterImage1;
    public Sprite characterImage2;

    public RectTransform rect;

    public void SelectCharater1()
    {
        characterBtnImage.GetComponent<Image>().sprite = characterImage1;
        rect.sizeDelta = new Vector2(400, 400);
        rect.position = new Vector2(710, 610);

        player.GetComponentInChildren<SpriteRenderer>().sprite = characterRenderer1.GetComponent<SpriteRenderer>().sprite;
    }

    public void SelectCharater2()
    {
        characterBtnImage.GetComponent<Image>().sprite = characterImage2;
        rect.sizeDelta = new Vector2(150, 300);
        rect.position = new Vector2(710, 590);

        player.GetComponentInChildren<SpriteRenderer>().sprite = characterRenderer2.GetComponent<SpriteRenderer>().sprite;
    }
}