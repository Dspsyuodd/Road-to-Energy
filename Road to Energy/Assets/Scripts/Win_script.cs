using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Win_script : MonoBehaviour
{
    public GameObject Win_panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Win_panel.SetActive(true);
            Time.timeScale = 0f;
            Pause_script.GameIsPause = true;
        }
    }
    public void Next_level()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Time.timeScale = 1f;
        Pause_script.GameIsPause = false;
    }
    
}
