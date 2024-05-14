using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    
    public static GameManager Instance;

    private void Awake()
    {
        // 게임매니저 싱글톤화
        if (Instance == null)
        {
            Instance = this;
        }
        
        // 게임 시작 직후 움직일 수 없게 만듦
        player.GetComponent<TopDownMovement>().enabled = false;
        player.GetComponentInChildren<SpriteRenderer>();
    }

    void Start()
    {
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        
    }
}
