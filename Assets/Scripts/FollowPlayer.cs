using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	public GameObject player;
	private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        // Save the initial distance between the player's vehicle and the camera.
		//offset = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Maintain the camera's position relative to the player.
		transform.position = player.transform.position + offset;
    }
}
