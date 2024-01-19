using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class diChuyenPlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    public int tocDo = 4;
    public float traiPhai;
    public bool isFacingRight = true;

    private bool isJumping = false;
    private int jumpCount = 0;
    public int maxJumpCount = 2;
    public float jumpForce = 10f;

    void Start()
    {

    }
    float horizontalMove = 0f;
    void Update()
    {
        traiPhai = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(tocDo * traiPhai, rb.velocity.y);

        if (isFacingRight == true && traiPhai == -1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            isFacingRight = false;
        }
        if (isFacingRight == false && traiPhai == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
            isFacingRight = true;
        }

        anim.SetFloat("Speed", Mathf.Abs(traiPhai));


        if (Input.GetButtonDown("Jump") && (jumpCount < maxJumpCount || rb.velocity.y == 0))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isJumping = true;
            anim.SetBool("Nhay", true);
            jumpCount++;
        }

        if (rb.velocity.y == 0 && isJumping)
        {
            isJumping = false;
            anim.SetBool("Nhay", false);
            jumpCount = 0;
        }

    }
}