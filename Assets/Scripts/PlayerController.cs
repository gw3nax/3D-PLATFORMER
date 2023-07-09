using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Скорость персонажа")]
    public float speed = 20f;
    [Header("Скорость персонажа при беге")]
    public float runSpeed = 30f;
    [Header("Скорость персонажа при медленной ходьбе")]
    public float sneakSpeed = 3f;
    [Header("Скорость персонажа в увеличенном виде")]
    public float speedOfBigPlayer = 0.5f;
    [Header("Персонаж на земле?")]
    public bool isGrounded;
    public Rigidbody rb;
    [Header("Сила прыжка")]
    public float JumpForce = 250;
    [Header("Сила прыжка большого персонажа")]
    public float JumpForceOfBigPlayer = 150;
    [Header("Персонаж вырос?")]
    public bool isGrowed = false;

    void Update()
    {
        GetInput();
    }
    private void GetInput()
    {
        Vector3 dir = transform.forward * Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isGrowed == true)
            {
                transform.localScale = new Vector3(0.25f,0.25f,0.25f);
                isGrowed = false;
            }
            else
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                isGrowed = true;
            }
        }
        /*  if (Input.GetKeyDown(KeyCode.G))    
          {
            Physics.gravity = -Physics.gravity;  //Смена гравитации
        }  */
        if (Input.GetButton("Horizontal"))
        {   
            if (isGrowed == false)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, runSpeed * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.LeftControl))
                {
                    transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, sneakSpeed * Time.deltaTime);
                }
                else
                {
                    transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.LeftControl))
                {
                    transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, sneakSpeed * Time.deltaTime);
                }
                else
                {
                    transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speedOfBigPlayer * Time.deltaTime);
                }
            }

            
            
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                if (isGrowed == false)
                {
                    rb.AddForce(transform.up * JumpForce);
                }
                else
                {
                    rb.AddForce(transform.up * JumpForceOfBigPlayer);
                }
            }
        }
    }private void OnTriggerStay(Collider collision) 
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    private void OnTriggerExit(Collider collision)
     {
         if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}

