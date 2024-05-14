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
        // 1번 캐릭터로 변경했을 경우 이미지 및 스프라이트 렌더러 변경
        characterBtnImage.GetComponent<Image>().sprite = characterImage1;
        rect.sizeDelta = new Vector2(400, 400);
        rect.localPosition = new Vector2(0, 70);

        player.GetComponentInChildren<SpriteRenderer>().sprite = characterRenderer1.GetComponent<SpriteRenderer>().sprite;
        player.GetComponentInChildren<Image>().rectTransform.localPosition = new Vector3(0, 75, 0);

    }

    public void SelectCharater2()
    {
        // 2번 캐릭터로 변경했을 경우 이미지 및 스프라이트 렌더러 변경
        characterBtnImage.GetComponent<Image>().sprite = characterImage2;
        rect.sizeDelta = new Vector2(150, 300);
        rect.localPosition = new Vector2(0, 50);

        player.GetComponentInChildren<SpriteRenderer>().sprite = characterRenderer2.GetComponent<SpriteRenderer>().sprite;
        player.GetComponentInChildren<Image>().rectTransform.localPosition = new Vector3(0, 100, 0);
    }
}