using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 20.0f;
	public float turnSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// Get player input.
		float horizontalInput = Input.GetAxis("Horizontal");
		float forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle (player) forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
		// Turn the vehicle.
		transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
