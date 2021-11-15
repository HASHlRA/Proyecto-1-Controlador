using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10;
    public float turnSpeed = 10f;
    public float horizontalInput;
    private float verticalInput;

   
    // Update is called once per frame
    void Update()
    {
        // Tomamos eje horizontal del Input Manager
        horizontalInput = Input.GetAxis("Horizontal");
        // Tomamon eje vertical del Input Manager
        verticalInput = Input.GetAxis("Vertical");

        // Movimiento hacia delante
        transform.Translate(Vector3.forward * speed * Time.deltaTime *  verticalInput);

        // Movimiento lateral
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);

        // Rotación
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
