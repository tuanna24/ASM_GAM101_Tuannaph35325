using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelEndGame;
    public Rigidbody2D rigidbody2D;
    public AudioSource audio_game;
    public AudioSource audio_death;
    
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        audio_game.Play();
        FPS();
    }
    public void Jump()
    {
        Debug.Log("Vao ham Jump");
        rigidbody2D.AddForce(Vector2.up * 6, ForceMode2D.Impulse);
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
    public void ReStarGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FPS ()
    {
        Application.targetFrameRate = 30;  
    }
}
