using UnityEngine;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    public AudioSource music;
    private SoundController soundController;

    void Start()
    {
        music = GetComponent<AudioSource>();

        Button pauseButton = GameObject.Find("PauseButton").GetComponent<Button>();
        pauseButton.onClick.AddListener(PauseMusic);

        soundController = GetComponent<SoundController>();
        if (soundController == null)
        {
            Debug.LogError("No SoundController script found on this object.");
        }
    }

    void PauseMusic()
    {
        if (music.isPlaying)
        {
            music.Pause();
            soundController.Mute();
        }
    }
}
