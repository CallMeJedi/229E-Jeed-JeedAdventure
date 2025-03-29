using UnityEngine;

public class ThrowRock : MonoBehaviour
{
    [SerializeField] float force, mass, acc;

    public void CalculateForce()
    {
        force = mass * acc;
        GetComponent<Rigidbody>().AddRelativeForce(0, force,0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            CalculateForce();
        }
    }
}
