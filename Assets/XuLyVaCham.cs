using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class XuLyVaCham : MonoBehaviour
{
    public int Mau = 3;
    public int Vang = 0;
    public int Cherry = 0;
    public TextMeshProUGUI VangText;
    public TextMeshProUGUI CherryText;
    public TextMeshProUGUI MauText;
    public GameOver gameOver;
    public AudioSource audioGame;
    public AudioSource audioDie;
    public AudioSource audioCoin;
    public GameObject panelEndGame;

    void Start()
    {
        audioGame.Play();
        panelEndGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Vang"))
        {
            Vang = Vang + 5;
            audioCoin.Play();
            VangText.SetText(Vang.ToString());
            Destroy(collider2D.gameObject);
        }
        if (collider2D.CompareTag("Boss"))
        {
            Heart.Mau--;
            if (Heart.Mau <= 0)
            {
                audioGame.Stop();
                panelEndGame.SetActive(true);
                Time.timeScale = 0;
            }
            audioDie.Play();
        }
        if (collider2D.CompareTag("Cherry"))
        {
            Cherry = Cherry + 5;
            audioCoin.Play();
            CherryText.SetText(Cherry.ToString());
            Destroy(collider2D.gameObject);
        }
        if (collider2D.gameObject.tag == "BunnyDie")
        {
            var name = collider2D.attachedRigidbody.name;
            Destroy(GameObject.Find(name));
        }
        if (collider2D.gameObject.tag == "DogDie")
        {
            var name = collider2D.attachedRigidbody.name;
            Destroy(GameObject.Find(name));
        }
    }
    public void ReStarGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
