using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float movespeed = 3f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        movespeed = -movespeed;
        // Flip Sprite
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(movespeed, rb.velocity.y);
    }
}
