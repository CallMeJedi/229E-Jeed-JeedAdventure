using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.tag=="Obstacle")
        {
            print("Ur ded");
        }
        
        
        
    }
}



