using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 10f;
    public float horizontalMove = 0f;

    public float playerBounds = 5f;

    public Joystick joystick;

    void Update()
    {
        
        if (joystick.Horizontal >= .2f)
        {
        
            transform.Translate(Vector3.right * Time.deltaTime * playerSpeed);

        } 
        else if (joystick.Horizontal <= -.2f)
        {
        
            transform.Translate(Vector3.left * Time.deltaTime * playerSpeed);

        } 
        else 
        {
        
            transform.Translate(Vector3.right * Time.deltaTime * 0);
        
        }

    }

}
