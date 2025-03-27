using System;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] float force, mass, acc;

    public void CalculateForce()
    {
        force = mass * acc;
        GetComponent<Rigidbody>().AddRelativeForce(0, force,0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CalculateForce();
        }
    }
}
