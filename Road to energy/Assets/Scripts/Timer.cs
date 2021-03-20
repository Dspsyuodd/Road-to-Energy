using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public GameObject Plane;
    public GameObject HP;

    private float time_start = 60f;
    [SerializeField] private float deadLine = 52f;
    public float Up_Time = 20f;

    public Text TimerText;

    void Start()
    {
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
            Game_over();
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
    void Game_over()
    {
        Plane.SetActive(true);
        HP.SetActive(false);
        Time.timeScale = 0f;
        Pause_script.GameIsPause = true;
    }

    public void Restart()
    {
        time_start = 60f;
        Time.timeScale = 1f;
        Pause_script.GameIsPause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void Menu()
    {
        Pause_script.GameIsPause = false;
        Time.timeScale = 1f;
        time_start = 60f;
        SceneManager.LoadScene(0);   
    }
}
