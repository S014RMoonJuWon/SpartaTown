using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightUIBtn : MonoBehaviour
{
    public GameObject rightUI;

    public void CloseUI()
    {
        // �ΰ��� ������ UI ��
        rightUI.SetActive(false);
    }

    public void OpenUI()
    {
        // �ΰ��� ������ UI ��
        rightUI.SetActive(true);
    }
}
