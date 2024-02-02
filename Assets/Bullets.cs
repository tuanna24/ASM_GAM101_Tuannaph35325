using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulletspeed;
    Rigidbody2D rigidbody2D;
    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        if (transform.localPosition.z > 0)
        {
            rigidbody2D.AddForce(new Vector2(-1, 0) * bulletspeed, ForceMode2D.Impulse);
        }
        else rigidbody2D.AddForce(new Vector2(1, 0) * bulletspeed, ForceMode2D.Impulse);
    }
    void Start()
    {
        
    }

    void Update()
    {

    }
}
