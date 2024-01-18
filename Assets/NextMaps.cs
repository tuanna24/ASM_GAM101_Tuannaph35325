using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NextMaps : MonoBehaviour
{
    public string sceneToLoad; // Tên của Scene muốn chuyển đến
    public float delayBeforeLoad = 2f; // Độ trễ trước khi chuyển Scene

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Kiểm tra nếu người chơi chạm vào
            StartCoroutine(LoadNextSceneWithDelay());
        }
    }

    private IEnumerator LoadNextSceneWithDelay()
    {
        // Đợi độ trễ
        yield return new WaitForSeconds(delayBeforeLoad);

        // Nạp Scene mới
        SceneManager.LoadScene(sceneToLoad);
    }
}
