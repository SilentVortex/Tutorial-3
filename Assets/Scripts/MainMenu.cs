using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Load scene //
    public void playLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void playMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Quit game //
    public void quit()
    {
        Application.Quit();
        Debug.Log("Player has quit!");
    }
}
