using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource music;

    void Start()
    {
        music = GetComponent<AudioSource>();

        Button repeatButton = GameObject.Find("RepeatButton").GetComponent<Button>();
        repeatButton.onClick.AddListener(RepeatMusic);
    }

    void RepeatMusic()
    {
        music.Stop();
        music.Play();
    }
}