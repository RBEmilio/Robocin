using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{

    [SerializeField] private Vector2 moveSpeed;
    [SerializeField] private float speedMultiplier = 0.1f;
    private Vector2 offset;
    private Material material;
    private Rigidbody2D playerRB;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
        playerRB = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        offset = (playerRB.velocity.x * speedMultiplier)*moveSpeed * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
