using UnityEngine;

public class LevelEndTrigger : MonoBehaviour
{
    public GameObject levelCompleteUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            levelCompleteUI.SetActive(true);
            Debug.Log("LEVEL COMPLETED");
        }
    }
}
