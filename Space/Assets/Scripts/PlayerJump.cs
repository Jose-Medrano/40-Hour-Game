using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
	// Jump mods
	private float fallGravity = 3.0f;
	private float shortHop = 2.5f;
	bool jumpStarted = false;
	float maxJump = 3.25f;
	float remainingJump;
	
	// Jump speed
    float initJump = 4f;
	
	// Rigidbody
    Rigidbody2D rb;
	
    // Get components
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		remainingJump = maxJump;
    }

    void Update()
    {
		// vertical movement
        float moveY = rb.velocity.y;
		
		// Standard jump
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            moveY += initJump;
        } else if (IsGrounded()) {
			remainingJump = maxJump;
		}
		
		// Continuing jump
		if (Input.GetKey(KeyCode.Space)) { 
			if (remainingJump > 0) {
				moveY += remainingJump/2;
				remainingJump /= 2;
			}
		} else if (IsGrounded()) {
			remainingJump = maxJump;
		}
		
		// Heavier fall
		if (rb.velocity.y < 0) {
			rb.gravityScale = fallGravity;
		
		// Short hops
		} else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space)) {
			rb.gravityScale = shortHop;
		} else {
			rb.gravityScale = 1.0f;
		}
				
		// Apply vertical momentum
        Vector2 movement = new Vector2(rb.velocity.x, moveY);
        rb.velocity = movement;
    }

    public bool IsGrounded()
    {
		RaycastHit2D hit = Physics2D.Raycast(transform.position - new Vector3(0, transform.localScale.y / 2 + 0.1f, 0), Vector2.down, 0.05f);
		if (hit && hit.collider.gameObject.CompareTag("Platform")) return true;
		else return false;
    }
}
