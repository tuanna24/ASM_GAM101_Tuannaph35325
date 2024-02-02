using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiChuyenMobile : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public int jumpCount = 0;
    public int maxJumpCount = 2;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        if (jumpCount < maxJumpCount)
        {
            Debug.Log("Vao ham Jump");
            rigidbody2D.AddForce(Vector2.up * 6, ForceMode2D.Impulse);
        }
    }

    public void Left()
    {
        Debug.Log("Vao ham Left");
        rigidbody2D.AddForce(Vector2.left * 3, ForceMode2D.Impulse);
    }

    public void Right()
    {
        Debug.Log("Vao ham Right");
        rigidbody2D.AddForce(Vector2.right * 3, ForceMode2D.Impulse);
    }

    public void ResetJumpCount()
    {
        jumpCount = 0;
    }
}
