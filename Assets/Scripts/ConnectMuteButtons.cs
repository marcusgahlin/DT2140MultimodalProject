using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConnectMuteButtons : MonoBehaviour
{
    [SerializeField]
    public Button GuitarMute;

    [SerializeField]
    public Button GuitarUnmute;

    [SerializeField]
    public Button BassMute;

    [SerializeField]
    public Button BassUnmute;

    [SerializeField]
    public Button DrumsMute;

    [SerializeField]
    public Button DrumsUnmute;

    [SerializeField]
    public Button SynthMute;

    [SerializeField]
    public Button SynthUnmute;

    [SerializeField]
    public Button VocMute;

    [SerializeField]
    public Button VocUnmute;

    [SerializeField]
    public Button Play;

    [SerializeField]
    public Button Pause;


    public void OnGuitarMuteClick()
    {
        GuitarMute.gameObject.SetActive(false);
        GuitarUnmute.gameObject.SetActive(true);
    }

    public void OnGuitarUnmuteClick()
    {
        GuitarMute.gameObject.SetActive(true);
        GuitarUnmute.gameObject.SetActive(false);
    }

    public void OnBassMuteClick()
    {
        BassMute.gameObject.SetActive(false);
        BassUnmute.gameObject.SetActive(true);
    }

    public void OnBassUnmuteClick()
    {
        BassMute.gameObject.SetActive(true);
        BassUnmute.gameObject.SetActive(false);
    }

    public void OnDrumsMuteClick()
    {
        DrumsMute.gameObject.SetActive(false);
        DrumsUnmute.gameObject.SetActive(true);
    }

    public void OnDrumsUnmuteClick()
    {
        DrumsMute.gameObject.SetActive(true);
        DrumsUnmute.gameObject.SetActive(false);
    }

    public void OnSynthMuteClick()
    {
        SynthMute.gameObject.SetActive(false);
        SynthUnmute.gameObject.SetActive(true);
    }

    public void OnSynthUnmuteClick()
    {
        SynthMute.gameObject.SetActive(true);
        SynthUnmute.gameObject.SetActive(false);
    }

    public void OnVocMuteClick()
    {
        VocMute.gameObject.SetActive(false);
        VocUnmute.gameObject.SetActive(true);
    }

    public void OnVocUnmuteClick()
    {
        VocMute.gameObject.SetActive(true);
        VocUnmute.gameObject.SetActive(false);
    }

    public void OnPlayClick()
    {
        Play.gameObject.SetActive(false);
        Pause.gameObject.SetActive(true);
    }

    public void OnPauseClick()
    {
        Play.gameObject.SetActive(true);
        Pause.gameObject.SetActive(false);
    }
}
