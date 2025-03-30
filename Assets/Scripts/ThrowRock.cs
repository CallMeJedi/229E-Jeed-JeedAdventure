using UnityEngine;

public class ThrowRock : MonoBehaviour
{
    [SerializeField] float force, mass, acc;

    public void CalculateForce()
    {
        force = mass * acc;
        GetComponent<Rigidbody>().AddRelativeForce(force, 0,0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            CalculateForce();
        }
    }
}
