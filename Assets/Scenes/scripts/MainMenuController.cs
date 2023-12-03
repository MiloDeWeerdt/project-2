using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public CanvasGroup OptionPane1;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Option()
    {
        OptionPane1.alpha = 1;
        OptionPane1.blocksRaycasts = true;
    }
    public void Back()
    {
        OptionPane1.alpha = 0;
        OptionPane1.blocksRaycasts = false;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
