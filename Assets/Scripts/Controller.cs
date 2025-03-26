using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Controller : MonoBehaviour
{
    public float speed;
    // public float rotateSpeed;
    public float jumpSpeed;
    private float ySpeed;
    private CharacterController control;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // control = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");

        Vector3 moveDirection = new Vector3(horizontalMove, 0, 0);
        moveDirection.Normalize();
        float magnitude = moveDirection.magnitude;
        magnitude = Mathf.Clamp01(magnitude);
        transform.Translate(moveDirection * speed * Time.deltaTime,Space.World);

        // control.SimpleMove(moveDirection * magnitude * speed);
        
        ySpeed += Physics.gravity.y * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ySpeed = -0.5f;
        }

        Vector3 vel = moveDirection * magnitude;
        vel.y = ySpeed;
        transform.Translate(vel * Time.deltaTime);
        // control.Move(vel * Time.deltaTime);



    }
   
}
