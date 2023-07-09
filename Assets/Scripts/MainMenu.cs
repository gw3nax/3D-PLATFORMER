using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Levels");
        Debug.Log("Уровни");
    }
    public void Settings()
    {
        
        Debug.Log("Настройки");
    }
    public void LoadShop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Вышел");
    }
}
