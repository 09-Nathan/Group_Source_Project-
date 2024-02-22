using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void StartGameClick()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Next()
    {
        SceneManager.LoadScene(2);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void intro()
    {
        SceneManager.LoadScene(6);
    }

}
