using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


 

    public float speed;
    public float tilt;
    

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = movement * speed;

        rigidbody.position = new Vector3
        (
            rigidbody.position.x,
            0.0f,
            rigidbody.position.z
        );

        rigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, rigidbody.velocity.x * -tilt);
    }

}
