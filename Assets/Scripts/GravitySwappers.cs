using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwappers : MonoBehaviour
{
    public bool isGravitySwapped = false;
    private void Start() 
    {
        isGravitySwapped = false;
    }
    void Update()
    {
        if (isGravitySwapped == true)
        {
            Physics.gravity = new Vector3(0,10,0);
        }
        if (isGravitySwapped == false)
        {
            Physics.gravity = new Vector3(0,-10,0);
        }
    }
    private void OnTriggerStay(Collider Swapper) 
    {
        if (Swapper.gameObject.tag == "GravitySwapper")
        {
            isGravitySwapped = true;
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        isGravitySwapped = false;
    }
}
