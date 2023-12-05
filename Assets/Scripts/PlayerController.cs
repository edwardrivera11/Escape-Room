using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private float speed = 8.0f;
   private float turnSpeed = 20.0f;

   private float horizontalInput;
   private float forwardInput;

   private float xRange = 5.0f;
   private float zRange = 5.0f;

   public float RotateSpeed = 3.0f;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        //move player forwards and backwards based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

    }
}
