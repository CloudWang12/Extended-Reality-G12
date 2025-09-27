using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    // Start is called before the first frame update


    public float TotalTime;
    private float RemainingTime;
    public Text TimerText;
    
    void Start()
    {
        RemainingTime = TotalTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (RemainingTime > 0)
        {
            RemainingTime -= Time.deltaTime;
            if (RemainingTime < 0)
                RemainingTime = 0;
            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        int minues = Mathf.FloorToInt(RemainingTime / 60);
        int seconds = Mathf.FloorToInt(RemainingTime % 60);
        TimerText.text = string.Format("{0:00}:{1:00}", minues, seconds);
    }
}
