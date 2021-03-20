using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public GameObject Plane;
    public GameObject HP;
    public static bool GameStop = false;
    private float time_start = 60f;
    private float deadLine = 50f;
    public float Up_Time = 20f;
    public Text TimerText;
    void Start()
    {
        time_start = 60f;
        TimerText.text = time_start.ToString();
    }

    void Update()
    {
        if (time_start > deadLine)
        {
            time_start -= Time.deltaTime;
            TimerText.text = Mathf.Round(time_start).ToString();

        }
        else
        {
            Plane.SetActive(true);
            Time.timeScale = 0f;
            GameStop = !GameStop;

}
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("UpTime"))
        {
            time_start += 20f;
            Destroy(other.gameObject);
        }
    }
    public void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameStop = !GameStop;
        Time.timeScale = 1f;

    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        GameStop = !GameStop;
    }
}
