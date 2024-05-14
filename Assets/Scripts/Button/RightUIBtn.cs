using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightUIBtn : MonoBehaviour
{
    public GameObject rightUI;

    public void CloseUI()
    {
        // 인게임 오른쪽 UI 끔
        rightUI.SetActive(false);
    }

    public void OpenUI()
    {
        // 인게임 오른쪽 UI 켬
        rightUI.SetActive(true);
    }
}
