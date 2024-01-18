using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuChucNang : MonoBehaviour
{
    public void StarGame()
    {
        SceneManager.LoadScene(1); // nhap man scene muon chuyen vao
    }
    public void ExitGame ()
    {
        Application.Quit();
    }
    public void QuayLaiMan1 ()
    {
        SceneManager.LoadScene(1);
    }
    public void ChoiMan2 ()
    {
        SceneManager.LoadScene(2);
    }
    public void VeMenu () 
    {
        SceneManager.LoadScene (0);
    }
    public void QuayLaiMan2 () 
    {
        SceneManager.LoadScene(2);
    }
    public void ChoiMan1 ()
    {
        SceneManager.LoadScene(1);
    }
}
