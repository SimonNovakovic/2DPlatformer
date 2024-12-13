using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 moveInput;
    [SerializeField] float playerSpeed = 5f;
    [SerializeField] ContactFilter2D groundfilter;
    bool isGrounded;
    float jumpSpeed = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Hazard"))
        {

        }
    }

    private void FixedUpdate()
    {
        isGrounded = rb.IsTouching(groundfilter);
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void OnJump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, 10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveInput.x * playerSpeed, rb.velocity.y);
    }
}
