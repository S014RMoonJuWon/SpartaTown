using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightUIBtn : MonoBehaviour
{
    public GameObject rightUI;

    public void CloseUI()
    {
        rightUI.SetActive(false);
    }

    public void OpenUI()
    {
        rightUI.SetActive(true);
    }
}
