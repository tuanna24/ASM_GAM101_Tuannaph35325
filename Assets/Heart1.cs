using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    public static int Mau = 3;
    public Image[] HetMau;
    public Sprite MaxHP;
    public Sprite MinHP;

    void Awake () 
    {
        Mau = 3;
    }
  
    void Update()
    {
        foreach ( Image img in HetMau)
        {
            img.sprite = MinHP;
        }
        for (int i = 0; i < Mau; i++)
        {
            HetMau[i].sprite = MaxHP;
        }
    }
}
