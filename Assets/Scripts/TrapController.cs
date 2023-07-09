using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    public float TimeForOpen = 1f;
    public float TimeForClose = 3f;
    public Collider TrapCollider;
    public bool isTrapTriggered = false;
    void Start()
    {
    
    }
    void Update()
    {
        if (isTrapTriggered == true)
        {
            TimeForOpen -= Time.deltaTime;
        }
        if (TimeForOpen <= 0f)
        {
            TrapCollider.enabled = false;
            isTrapTriggered = false;
            TimeForClose -= Time.deltaTime;
            if (TimeForClose <= 0f)
            {
                TrapCollider.enabled = true;
                TimeForClose = 3f;
                TimeForOpen = 1f;
            }
        }
    }
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
            isTrapTriggered = true;
        }
    }

}
