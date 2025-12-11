using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public AudioClip menuMusic;  // ← add this

    public void LoadHome()
    {
        PersistentMusic.instance.SwitchMusic(menuMusic);
        SceneManager.LoadScene("Home");
    }

    public void LoadLevelSelect()
    {
        PersistentMusic.instance.SwitchMusic(menuMusic);
        SceneManager.LoadScene("LevelSelect");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void LoadPracticeLevel()
    {
        SceneManager.LoadScene("PracticeLevel");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
