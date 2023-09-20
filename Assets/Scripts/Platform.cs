using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    
    public float jumpForce = 10f;
    public float speed = 10f;
    private float bound = -13.5f;

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

    void Update() 
    {
    
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.z < bound) 
        {
        
            Destroy(gameObject);

        }

    }
}
