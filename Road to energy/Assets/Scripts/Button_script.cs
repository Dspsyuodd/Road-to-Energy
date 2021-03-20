using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_script : MonoBehaviour
{
    public void Exit_game()
    {
        Invoke("Exit", 1f);
    }

    private void Exit()
    {
        Application.Quit();
    }

    public void Start_game()
    {
        Invoke("StartG", 1f);
    }
    private void StartG()
    {
        SceneManager.LoadScene(1);
    }

    public void Restart()
    {
        Invoke("Rest", 1f);
    }
    private void Rest()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit_to_menu()
    {
        Invoke("ExitM", 1f);
    }
    private void ExitM()
    {
        SceneManager.LoadScene(0);
    }
    public void Level2()
    {
        SceneManager.LoadScene(2);
    }
    public void Level3()
    {
        SceneManager.LoadScene(3);
    }
}
