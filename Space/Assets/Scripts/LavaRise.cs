using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRise : MonoBehaviour
{
    float rise;
    public bool active = true;
	
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && 
			GameObject.Find("Player").GetComponent<PlayerJump>().IsGrounded())
        {
            rise = 1.5f;
        }

        if (rise > 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, transform.position.z);
            rise -= 0.1f;
        }

        if (!active)
        {
            transform.position = new Vector3(0, -54, -1);
        }
    }
}
