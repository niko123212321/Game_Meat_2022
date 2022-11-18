using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
   public void ClickStart()
    {
        SceneManager.LoadScene(1);
    }

    public void ClickGallery()
    {
        SceneManager.LoadScene("");
    }
    public void ClickQuit()
    {
        Application.Quit();
    }
    public void ClickCredits()
    {
        SceneManager.LoadScene("");
    }
}
