using UnityEngine;

public class spikes : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Daño al jugador");
            //scollision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }

}
