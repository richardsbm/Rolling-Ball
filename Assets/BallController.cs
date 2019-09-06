using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public int speed;
    Rigidbody ballRigidBody; 

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
        ballRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log( Input.GetAxis("Horizontal") );

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        
        // This text is ignored by the computer. 
        // This is only for us.
        // Yo.
        // Now. We add the direction as a force to the Rigidbody.

        ballRigidBody.AddForce(direction * speed);
        
    }
}
