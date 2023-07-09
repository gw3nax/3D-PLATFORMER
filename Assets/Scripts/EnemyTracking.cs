using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTracking : MonoBehaviour
{
    public Transform Player;
    public Vector3 EnemyTracker;
    public float speed = 4f;
    public bool isEnemyTriggered;
    private void Update() 
    {
        if (isEnemyTriggered == true)
        {
            Tracking();
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            isEnemyTriggered = true;
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            isEnemyTriggered = false;
        }
    }
    public void Tracking()
    {
        EnemyTracker = Player.position;
        transform.position = Vector3.MoveTowards(transform.position, EnemyTracker, speed * Time.deltaTime);
    }
}
