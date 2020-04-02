using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Game Started!");
        SceneManager.LoadScene("Transition");
    }

    public void ExitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
