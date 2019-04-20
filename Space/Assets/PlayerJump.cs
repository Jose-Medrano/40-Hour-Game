using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    float jumpSpeed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        jumpSpeed = 8;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveY = rb.velocity.y;
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            moveY += jumpSpeed;
        }
        Vector2 movement = new Vector2(rb.velocity.x, moveY);
        rb.velocity = movement;
    }

    bool IsGrounded()
    {
        return Physics2D.Raycast(transform.position - new Vector3(0, transform.localScale.y / 2 + 0.1f, 0), Vector2.down, 0.1f);
    }
}
