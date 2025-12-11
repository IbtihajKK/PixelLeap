using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndByPosition : MonoBehaviour
{
    public Transform player;           // Drag Player here
    public float endXPosition = 50f;   // Where the level ends

    public GameObject levelCompleteUI; // Drag level panel here

    bool levelEnded = false;

    void Update()
    {
        if (!levelEnded && player.position.x >= endXPosition)
        {
            levelEnded = true;
            EndLevel();
        }
    }

    void EndLevel()
    {
        Time.timeScale = 0f;
        levelCompleteUI.SetActive(true);
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Home"); // Change name if needed
    }
}
