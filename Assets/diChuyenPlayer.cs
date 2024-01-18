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
    // public int Vang = 0;
    // public int Mau = 3;
    // public int Cherry = 0;

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     Debug.Log("Trigger vào: " + other.gameObject.tag);

    //     if (other.gameObject.tag == "Vang")
    //     {
    //         Vang++;
    //         Destroy(other.gameObject);
    //     }
    //     if (other.gameObject.tag == "cherry") {
    //         Cherry++;
    //         Destroy(other.gameObject);
    //     }
    // }

    // private void OnCollisionEnter2D (Collider2D collider2D)
    // {
    //     if (collider2D.CompareTag("Vang")) {
    //         Vang++;
    //         Destroy(collider2D.gameObject);
    //     }
    //     if (collider2D.CompareTag("Cherry")) {
    //         Cherry++;
    //         Destroy(collider2D.gameObject);
    //     }
    //     if (collider2D.CompareTag("Dog")) {
    //         Mau--;
    //     }
    //     if (collider2D.CompareTag("Bunny")) {
    //         Mau--;
    //     }
    // }

    // private void OnCollisionEnter2D(Collision2D other)
    // {
    //     Debug.Log("Va chạm vào: " + other.gameObject.tag);
    // }

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