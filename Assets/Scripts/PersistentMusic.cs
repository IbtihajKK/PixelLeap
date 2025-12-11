using UnityEngine;
using UnityEngine.Audio;

public class PersistentMusic : MonoBehaviour
{
    public static PersistentMusic instance;
    public AudioSource source;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SwitchMusic(AudioClip clip)
    {
        if (source == null) return;

        source.Stop();        // always stop current audio
        source.clip = clip;   // set new clip (even if same)
        source.time = 0f;     // restart from beginning
        source.Play();        // play new clip
    }
  


}
