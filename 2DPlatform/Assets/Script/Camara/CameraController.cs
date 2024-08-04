using UnityEngine;

public class Camera : MonoBehaviour
{
    //Camara de habitación
    [SerializeField] private float speed;

    //Seguir al jugador
    [SerializeField] private Transform player;
    [SerializeField]private float aheadDistance;
    [SerializeField]private float cameraSpeed;
    private float lookAhead;

    private void Update()
    {
        //Camara de habitación
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z), ref velocity, speed);

        //Seguir al jugador
        transform.position = new Vector3(player.position.x + lookAhead, transform.position.y, transform.position.z);
        lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * player.localScale.x), Time.deltaTime * cameraSpeed);
    }
}
