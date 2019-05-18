using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceKillBox : MonoBehaviour
{
	bool started = false;
    public bool falling = false;
	float speed = 0.03f;

    private void Update()
    {
		// Wait for player to move to start
		if (Input.anyKey) started = true;
		
		if (started) {
			if (falling)
			{
				transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
			} else {
				transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
			}
		}
    }


}
