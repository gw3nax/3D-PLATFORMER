using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCollecting : MonoBehaviour
{
    public DeathTimer Timer;
    public float PlusTime = 15f;
    public float MinusTime = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlusTime")
        {
            Timer.TimerStart += PlusTime;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "MinusTime")
        {
            Timer.TimerStart -= MinusTime;
            Destroy(other.gameObject);
        }    
    }
}
