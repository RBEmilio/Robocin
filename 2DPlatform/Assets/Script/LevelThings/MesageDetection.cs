using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesageDetection : MonoBehaviour
{
    [SerializeField] private GameObject text;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            text.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            text.SetActive(false);
        }
    }


}
