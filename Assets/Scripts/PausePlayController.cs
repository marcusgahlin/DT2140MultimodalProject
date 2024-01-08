using UnityEngine;
using UnityEngine.UI;

public class PausePlayController : MonoBehaviour
{
    public AudioSource music;
    private bool isPaused = false;
    private bool audioWasMuted;

    private SoundController soundController;

    void Start()
    {
        music = GetComponent<AudioSource>();

        Button pausePlayButton1 = GameObject.Find("PausePlayButton1").GetComponent<Button>();
        pausePlayButton1.onClick.AddListener(Pause);

        Button pausePlayButton2 = GameObject.Find("PausePlayButton2").GetComponent<Button>();
        pausePlayButton2.onClick.AddListener(Pause);

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
            audioWasMuted = music.mute == true;
            music.UnPause();
            if (audioWasMuted)
            {
                music.mute = true;
            }
        }
        else
        {
            music.Pause();
        }

        soundController.Mute();

        isPaused = !isPaused;
    }
}









