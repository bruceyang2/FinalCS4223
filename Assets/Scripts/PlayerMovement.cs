using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 

    private Rigidbody rb; 

    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        if (rb == null) 
        {
            Debug.LogError("Rigidbody not found on " + gameObject.name);
        }
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical"); 

        // Calculate the new position
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * moveSpeed;

        // Apply the movement to the Rigidbody
        rb.MovePosition(transform.position + movement * Time.deltaTime);
    }
}
