using UnityEngine;

public class AboutMenu : MonoBehaviour
{
    public GameObject aboutPanel;

    public void OpenAbout()
    {
        aboutPanel.SetActive(true);
        Time.timeScale = 0f;  // freeze background if you want
    }

    public void CloseAbout()
    {
        aboutPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
