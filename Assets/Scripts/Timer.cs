using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public PlayerController playerController;
    AudioManager audioManager;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime = 60;    
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        if (remainingTime == 10)
        {
            timerText.color = Color.red;
            audioManager.PlaySFX(audioManager.littleTime);
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            playerController.EndGame();
        }
        
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);  
    }

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
}
