using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    
    public float jumpForce = 10f;

    void OnCollisionEnter(Collision collision)
    {
    
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();

        if (rb != null)
        {
        
            Vector3 velocity = rb.velocity;
            velocity.y = jumpForce;

            rb.velocity = velocity;

        }

    }
}
