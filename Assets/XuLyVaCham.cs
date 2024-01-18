using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class XuLyVaCham : MonoBehaviour
{
    public int Mau = 3;
    public int Vang = 0;
    public int Cherry = 0;
    public TextMeshProUGUI VangText;
    public TextMeshProUGUI CherryText;
    public TextMeshProUGUI MauText;
    public GameOver gameOver;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Vang"))
        {
            Vang++;
            VangText.SetText(Vang.ToString());
            Destroy(collider2D.gameObject);
        }
        if (collider2D.CompareTag("Bunny") || collider2D.CompareTag("Dog"))
        {
            Heart.Mau--;
            if(Heart.Mau <= 0)
            {
                SceneManager.LoadScene(3);
            }
        }
         if (collider2D.CompareTag("Cherry"))
        {
            Cherry++;
            CherryText.SetText(Cherry.ToString());
            Destroy(collider2D.gameObject);
        }
    }
}
