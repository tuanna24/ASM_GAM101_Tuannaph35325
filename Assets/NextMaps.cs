using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NextMaps : MonoBehaviour
{
    public string sceneToLoad;
    public float delayBeforeLoad = 2f;
    public GameObject winPanel;
    public GameObject pauseMenu;
    public AudioSource audioGame;
    public AudioSource audioWin;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ShowWinPanel();
            Time.timeScale = 0;
            audioGame.Stop();
            audioWin.Play();
        }
    }

    private IEnumerator LoadNextSceneWithDelay()
    {
        yield return new WaitForSeconds(delayBeforeLoad);
        SceneManager.LoadScene(sceneToLoad);
    }
    private void ShowWinPanel()
    {
        winPanel.SetActive(true);
    }
    public void Start()
    {
        winPanel.SetActive(false);
        audioGame.Play();
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
    public void GotoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
