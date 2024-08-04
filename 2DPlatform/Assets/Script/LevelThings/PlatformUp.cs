using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUp : MonoBehaviour
{
    [SerializeField] private Transform[] movePoints;
    [SerializeField] private float speed;
    private float waitTime;
    private bool now = false;

    [SerializeField] private float startWaitingTime = 2;

    private int i;


    private void Start()
    {
        waitTime = startWaitingTime;
    }
    private void Update()
    {

        if (now == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, movePoints[i].position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, movePoints[i].position) < 0.1f)
            {
                if (waitTime <= 0)
                {
                    if (movePoints[i] != movePoints[movePoints.Length - 1])
                    {
                        i++;
                    }
                    else
                    {
                        i = 0;
                    }
                    waitTime = startWaitingTime;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            now = true;
        }
    }

}
