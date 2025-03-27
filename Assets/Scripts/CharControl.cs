using UnityEngine;

public class CharControl : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed
    public float jumpForce = 7f; // Jump force
    public Transform groundCheck; // Reference to ground check object
    public LayerMask groundLayer; // Ground layer mask
    private bool isGrounded; // Whether the player is grounded
    [SerializeField] Rigidbody rb; // Rigidbody component

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component attached to the character
    }

    void Update()
    {
        // Check if the player is grounded
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.5f, groundLayer);

        // Move the player left or right
        float moveInput = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(moveInput * moveSpeed, rb.linearVelocity.y, 0);
        rb.linearVelocity = move;

        // Jump if grounded and the jump button is pressed
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
        
        
    }
}
