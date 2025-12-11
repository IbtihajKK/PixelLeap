using UnityEngine;

public class MusicSwitcher : MonoBehaviour
{
    public AudioClip music;

    private void Start()
    {
        PersistentMusic.instance.SwitchMusic(music);
    }
}
