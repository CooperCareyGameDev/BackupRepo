using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour
{
    public int moveDir = 0;
    public int mobileDir;
    public float moveSpeed = 1.0f;
    public float jumpSpeed = 1.0f;
    bool grounded = false;
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    Animator ac;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        ac = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDir = 0;

        int inputDir = (int)Input.GetAxisRaw("Horizontal");
        moveDir += inputDir + mobileDir;
        moveDir = Mathf.Clamp(moveDir, -1, 1);
        Vector2 velocity = rb.velocity;
        velocity.x = moveDir * moveSpeed;
        rb.velocity = velocity;
        ac.SetFloat("xInput", moveDir);
        
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        if (rb.velocity.y < -0.1f && !grounded)
        {
            ac.SetTrigger("Fall");
        }
        if (inputDir < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (inputDir > 0)
        {
            spriteRenderer.flipX = false;
        }

        if (moveDir > 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = 1;
            transform.localScale = scale;

        }
        if (moveDir < 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = -1;
            transform.localScale = scale;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
            ac.SetBool("grounded", grounded);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = false;
            ac.SetBool("grounded", grounded);
        }
    }
    public void UpdateMoveDirection(int direction)
    {
        mobileDir = direction;

    }
    public void Jump()
    {
        if (grounded)
        {
            rb.AddForce(new Vector2(0, 100 * jumpSpeed));
            grounded = false;
            ac.SetTrigger("Jump");
        }
        ac.SetBool("grounded", grounded);
    }

}
