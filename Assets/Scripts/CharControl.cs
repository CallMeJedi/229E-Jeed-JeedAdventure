using System;
using UnityEngine;

public class CharControl : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed
    public float jumpForce = 5f;
    private Rigidbody rb;
    private bool hasJumped = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component attached to the character
    }

    void Update()
    {
       
        // Move the player left or right
        float moveInput = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(moveInput * moveSpeed, rb.linearVelocity.y, 0);
        rb.linearVelocity = move;
        
         if (Input.GetKeyDown(KeyCode.Space) && hasJumped == false)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJumped = true;
        }
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            hasJumped = false;
        }
    }
}
