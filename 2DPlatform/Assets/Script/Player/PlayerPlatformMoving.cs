using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformMoving : MonoBehaviour
{
    /*private Transform platform;
    private Vector3 lastPlatformPos;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MovingPlatform"))
        {
            platform = collision.transform;
            lastPlatformPos = platform.position;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MovingPlatform"))
        {
            platform = null;
        }
    }
    void Update()
    {
        if (platform != null)
        {
            Vector3 platformMovement = platform.position - lastPlatformPos;
            transform.position += platformMovement;
            lastPlatformPos = platform.position;
        }
    }*/
}
