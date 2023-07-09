using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    public Transform Player;
    public float CamSpeed = 5f;
    public Vector3 position;
    void Update()
    {
        position = Player.position;
        position.z = position.z - 2;
        position.y = position.y + 0.5f;
        position.x = position.x + 1;
        transform.position = Vector3.Lerp(transform.position, position, CamSpeed * Time.deltaTime);
    }
}
