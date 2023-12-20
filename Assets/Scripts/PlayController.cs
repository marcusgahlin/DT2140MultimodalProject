using UnityEngine;
using UnityEngine.UI;

public class PlayController : MonoBehaviour
{
    public AudioSource music;
    private SoundController soundController;

    void Start()
    {
        music = GetComponent<AudioSource>();

        Button playButton = GameObject.Find("PlayButton").GetComponent<Button>();
        playButton.onClick.AddListener(PlayMusic);

        soundController = GetComponent<SoundController>();
        if (soundController == null)
        {
            Debug.LogError("No SoundController script found on this object.");
        }
    }

    void PlayMusic()
    {
        if (!music.isPlaying)
        {
            music.Play();
        }
    }
}
