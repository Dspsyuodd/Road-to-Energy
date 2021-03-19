using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;

    [SerializeField]
    private float speedX = 1;


    private float horizontal;
    private bool isFaisingRight = true;

    const float speedMult = 50f;

    private bool isGround = false;
    private bool isJump = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground") && gameObject.CompareTag("Player"))
        {
            isGround = true;
        }
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.W) && isGround)
        {
            isJump = true;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speedX * speedMult * Time.fixedDeltaTime, rb.velocity.y);

        if (isJump)
        {
            rb.AddForce(new Vector2(0f, 4 * 500f));
            isGround = false;
            isJump = false;
        }

        if (horizontal > 0f && !isFaisingRight)
        {
            Flip();
        }
        else if (horizontal < 0f && isFaisingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        isFaisingRight = !isFaisingRight;
        Vector2 playerScale = transform.localScale;
        playerScale.x *= -1;
        transform.localScale = playerScale;
    }
}
