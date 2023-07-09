using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenController : MonoBehaviour
{
    public bool isDead = false;
    public GameObject DeathScreenUI;
    public GravitySwappers GravitySwap;

    private void Update() 
    {
        if (isDead)
        {
            GravitySwap.isGravitySwapped = false;
            DeathScreenUI.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0f;
        }
        if (isDead == false)
        {
            Time.timeScale = 1f;
        }
    }
    public void RestartGame()
    {
        Debug.Log("Рестарт");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
     
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Меню");
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Вышел");
    }
}
