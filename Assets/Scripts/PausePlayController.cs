using UnityEngine;
using UnityEngine.UI;

public class PausePlayController : MonoBehaviour
{
    public AudioSource music;
    private bool isPaused = false;

    private SoundController soundController;

    void Start()
    {
        music = GetComponent<AudioSource>();

        Button pausePlayButton = GameObject.Find("PausePlayButton").GetComponent<Button>();
        pausePlayButton.onClick.AddListener(Pause);

        soundController = GetComponent<SoundController>();
        if (soundController == null)
        {
            Debug.LogError("No SoundController script found on this object.");
        }
    }

    void Pause()
    {
        if (isPaused)
        {
            music.UnPause();
        }
        else
        {
            music.Pause();
        }

        soundController.Mute();

        isPaused = !isPaused;
    }
}










