using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private AudioClip mySound;
    [SerializeField] private int valor = 1;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private bool isSpecial = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (isSpecial == false)
            {
                SoundController.instance.StartSound(mySound);
                gameManager.Points(valor);
                Destroy(this.gameObject);
            }
            else
            {
                SoundController.instance.StartSound(mySound);
                gameManager.TotalSpecial(valor);

            }
        }
    }
}
