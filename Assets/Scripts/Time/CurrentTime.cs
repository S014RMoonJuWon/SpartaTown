using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTime : MonoBehaviour
{
    // 현재 시간 표시
    public Text currentTime;

    DateTime dateTime;

    private void Start() 
    {
        dateTime = DateTime.Now;
        currentTime.text = dateTime.ToString("HH:mm");
    }
}
