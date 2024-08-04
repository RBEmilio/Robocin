using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlatformMov : MonoBehaviour
{
    [SerializeField] private Transform[] movePoints;
    [SerializeField] private float speed;
    private float waitTime;

    [SerializeField] private float startWaitingTime = 2;

    private int i;


    private void Start()
    {
        waitTime = startWaitingTime;
    }
    private void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, movePoints[i].position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, movePoints[i].position) < 0.1f)
        {
            if(waitTime <= 0)
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
