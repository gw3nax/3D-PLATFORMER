using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathFloor : MonoBehaviour
{
    public RestartLevel Restart;
    public PlayerHealth Health;
    public PlayerController PlayerCon;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            if (PlayerCon.isGrowed == false)
            {
                Health.Health = 0;                
            }
            else
            {
                Health.GiantHealth = 0;
            }
        }
    }
}
