using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    /*UI*/
    public GameObject flashingDisplay;
    public GameObject timerUI;
    public GameObject gameOverScreen;
    private TextMeshProUGUI timeText;
    /*EXPERIMENT DATA*/
    public float timeRemaining = 5;
    private bool timerIsRunning = false;

    private float reactionTime = 0;
    private bool reactionTimerIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        timeText = timerUI.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning=false;
                TimeRunOut();
            }
        }

        if(reactionTimerIsRunning)
        {
            reactionTime += Time.deltaTime;
            if(Input.GetKeyDown("space"))
            {
                gameOverScreen.SetActive(true);
                DisplayTime(reactionTime);
                reactionTimerIsRunning =false;
            }
        }
    }

      private void TimeRunOut()
    {
        flashingDisplay.SetActive(true);
        reactionTimerIsRunning = true;
    }

 
        void DisplayTime(float timeToDisplay)
        {
            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);
            float milliSeconds = (timeToDisplay % 1) * 1000;
            timeText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliSeconds);
        }
    
}
