using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapcontroller : MonoBehaviour
{
    [SerializeField] private GameObject final;

    [SerializeField] private AudioSource stopMusic;
    [SerializeField] private AudioSource startMusic;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            stopMusic.Pause();
            startMusic.Play();
            final.SetActive(true);
        }
    }
}
