using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerInfoUI : MonoBehaviour
{
    public MoneyController AmountOfMoney;
    public PlayerHealth Health;
    public Text MoneyText;
    public Text HealthText;

   
    void Update()
    {
        MoneyText.text = AmountOfMoney.SumOfMoney.ToString();
        HealthText.text = Health.RealHealth.ToString();
    }
}
