using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeTroyMe : MonoBehaviour
{
    // Start is called before the first frame update
    public float AliveTime;
    void Start()
    {
        Destroy(gameObject, AliveTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
