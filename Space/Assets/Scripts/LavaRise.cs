using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRise : MonoBehaviour
{
	bool started = false;
    float rise;
    public bool rising = true;
	float speed = 0.03f;
	
    // Update is called once per frame
    void Update()
    {
		// Wait for player to move to start
		if (Input.anyKey) started = true;
		
        /*if (Input.GetKeyDown(KeyCode.Space) && 
			GameObject.Find("Player").GetComponent<PlayerJump>().IsGrounded())
        {
            rise = 2.5f;
        }*/
		
		if (started) {
			if (rising) {
				/*if (rise > 0)
				{
					transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f, transform.position.z);
					rise -= 0.05f;
				}*/
				transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
			} else {
				transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
			}
		}
    }
}
