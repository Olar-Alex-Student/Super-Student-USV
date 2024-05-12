using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        GameManager.Instance.NewGame();
    }

    public void QuitGame()
    {
        UnityEngine.Application.Quit();
    }
}
