using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_script : MonoBehaviour
{
    public void Exit_game()
    {
        Application.Quit();
    }

    public void Start_game()
    {
        SceneManager.LoadScene(1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Exit_to_menu()
    {
        SceneManager.LoadScene(0);
    }

}
