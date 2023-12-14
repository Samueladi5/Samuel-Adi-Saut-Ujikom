using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float totalTime = 60f;
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerText();
        }
        else
        {
            Debug.Log("Waktu Habissss");
        }
    }

    void UpdateTimerText()
    {
        timerText.text = currentTime.ToString("Timer : " + currentTime);
    }
}
