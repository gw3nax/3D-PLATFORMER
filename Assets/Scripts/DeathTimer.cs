using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeathTimer : MonoBehaviour
{
    public Text DeathTimerUI;
    public float TimerStart = 10f;
    public DeathScreenController DeathScreen;
    public Text DeathScreenText;
    public PlayerHealth Health;
    public PauseMenuControler PauseMenu;
    
    void Start()
    {
        DeathTimerUI.text = TimerStart.ToString("F1");
    }
    void Update()
    {
        if (TimerStart <= 15)
        {
            DeathTimerUI.color = Color.red;
        }
        if (TimerStart > 15)
        {
            DeathTimerUI.color = Color.white;
        }
        if (PauseMenu.GameIsPaused == false)
        {
            TimerStart -= Time.deltaTime;
        }
        if (TimerStart <= 0)
        {
            TimerStart = 0f;
            DeathScreenText.text = "Время вышло";
            Health.RealHealth = 0;
        }
        DeathTimerUI.text = TimerStart.ToString("F1");
    }
    
}
