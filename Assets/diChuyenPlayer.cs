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

    public Transform gunTip;
    public GameObject bullets;
    float fireRate = 0.5f;
    float nextFire = 0;

    void Start()
    {
        FPS();
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
        if (Input.GetAxisRaw("Fire1") > 0)
        {
            fireBullet();
        }
    }
    void fireBullet()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            if (isFacingRight)
            {
                Instantiate(bullets, gunTip.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            }
            else if (!isFacingRight)
            {
                Instantiate(bullets, gunTip.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            }
        }
    }
    private void FPS()
    {
        Application.targetFrameRate = 30;
    } 
}