using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_script : MonoBehaviour
{
    public void Exit_game()
    {
        Invoke("Quit", 1f);
    }

    public void Start_game()
    {
        Invoke("NextScene", 1f);
    }

    private void Quit()
    {
        Application.Quit();
    }

    private void NextScene()
    {
        SceneManager.LoadScene(1);
    }
}
