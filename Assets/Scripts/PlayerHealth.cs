using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    [Header("Здоровье обычного персонажа")]
    public float Health = 100;
    public float HealthConst = 100;
    [Header("Здоровье Гиганта")]
    public float GiantHealthConst = 400;
    public float GiantHealth = 400;
    [Header("Урон по обычному персонажу")]
    public float Damage = 20;
    [Header("Урон по Гиганту")]
    public float GiantDamage = 80;
    public float Heal = 20;
    public float GiantHeal = 80;
    public float RealHealth;
    public PlayerController PlayerCont;
    public DeathScreenController DeathScreen;
    
    private void Update() {        
        if (PlayerCont.isGrowed == false)
        {
            RealHealth = Health;
        }
        else
        {
            RealHealth = GiantHealth;
        }
        if (RealHealth <= 0)
        {
            DeathScreen.isDead = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GetDamage();
        }
        if (collision.gameObject.tag == "Heal")
        {
            GetHeal();
            Destroy(collision.gameObject);
        }
    }

    void GetDamage()
    {
        if (PlayerCont.isGrowed == false)
        {
            Health -= Damage;
            GiantHealth = GiantHealthConst * (Health / HealthConst);
        if (Health <= 0)
        {
            Health = 0;
        }
        }
        else
        {
            GiantHealth -= GiantDamage;
            Health = HealthConst * (GiantHealth / GiantHealthConst);
        if (GiantHealth <= 0)
        {
            GiantHealth = 0;
        }
        }
    }
    void GetHeal()
    {
        if (PlayerCont.isGrowed == false)
        {
            Health += Heal;
            GiantHealth = GiantHealthConst * (Health / HealthConst);
        if (Health >= HealthConst)
        {
            Health = HealthConst;
        }
        }
        else
        {
            GiantHealth += GiantHeal;
            Health = HealthConst * (GiantHealth / GiantHealthConst);
        if (GiantHealth >= GiantHealthConst)
        {
            GiantHealth = GiantHealthConst;
        }
        }
    }
}  
