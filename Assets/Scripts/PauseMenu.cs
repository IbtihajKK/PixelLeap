using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject pausePanel;

    [Header("Music")]
    public Slider musicSlider;
    private AudioSource musicSource;

    private bool isPaused = false;

    void Start()
    {
        // Try to find audio source (music) safely
        GameObject mm = GameObject.FindWithTag("MusicManager");

        if (mm != null)
        {
            musicSource = mm.GetComponent<AudioSource>();
        }
        else
        {
            Debug.LogWarning("PauseMenu: Could not find MusicManager with tag 'MusicManager'. Music Slider disabled.");
        }

        if (pausePanel != null)
            pausePanel.SetActive(false);

        if (musicSlider != null && musicSource != null)
        {
            musicSlider.value = musicSource.volume;
            musicSlider.onValueChanged.AddListener(SetMusicVolume);
        }
    }

    void Update()
    {
        // Press ESC (editor) or Back button (Android)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    // Called by Pause Button OR Escape key
    public void TogglePause()
    {
        if (isPaused)
            ResumeGame();
        else
            PauseGame();
    }

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;

        if (pausePanel != null)
            pausePanel.SetActive(true);
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;

        if (pausePanel != null)
            pausePanel.SetActive(false);
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToLevelSelect()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelSelect");
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Home");
    }

    public void SetMusicVolume(float v)
    {
        if (musicSource != null)
            musicSource.volume = v;
    }
}
