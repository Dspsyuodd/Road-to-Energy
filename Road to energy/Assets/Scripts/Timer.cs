using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public static float time_start = 60f;
    public Text TimerText;
    void Start()
    {
        TimerText.text = time_start.ToString();
    }

    void Update()
    {
        time_start -= Time.deltaTime;
        TimerText.text = Mathf.Round(time_start).ToString();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("UpTime"))
        {
            time_start += 20f;
        }
    }
}
