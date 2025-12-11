using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{
    public Sprite soundOnIcon;
    public Sprite soundOffIcon;

    private Image buttonImage;
    private bool isMuted = false;

    private void Start()
    {
        buttonImage = GetComponent<Image>();

        // Load saved mute state
        isMuted = PlayerPrefs.GetInt("Muted", 0) == 1;

        ApplySoundState();
    }

    public void ToggleSound()
    {
        isMuted = !isMuted;

        // Save state
        PlayerPrefs.SetInt("Muted", isMuted ? 1 : 0);

        ApplySoundState();
    }

    private void ApplySoundState()
    {
        AudioListener.volume = isMuted ? 0 : 1;

        // Update button icon
        if (buttonImage != null)
        {
            buttonImage.sprite = isMuted ? soundOffIcon : soundOnIcon;
        }
    }
}
