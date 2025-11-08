using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 100f;
    public Rigidbody rb;
    void FixedUpdate()
    {
        // Player 1 Input
        float player1Horizontal = Input.GetAxis("Player1Horizontal");
        float player1Vertical = Input.GetAxis("Player1Vertical");

        // Player 2 Input
        float player2Horizontal = Input.GetAxis("Player2Horizontal");
        float player2Vertical = Input.GetAxis("Player2Vertical");

        // Combine or process inputs
        Vector3 combinedMovement = new Vector3(player1Horizontal + player2Horizontal, 0, player1Vertical + player2Vertical);
        combinedMovement *= speed;
        //transform.Translate(combinedMovement * speed * Time.deltaTime, Space.World);
        //rb.AddForce(new Vector3 (player1Horizontal, 0, player1Vertical));
        rb.AddForce(combinedMovement);

    }
}
