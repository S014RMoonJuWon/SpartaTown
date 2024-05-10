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
        if (Instance == null)
        {
            Instance = this;
        }

        player.GetComponent<TopDownMovement>().enabled = false;
    }

    void Start()
    {
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        
    }
}
