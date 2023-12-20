using UnityEngine;
using UnityEngine.UI;

public class MuteButtonSwitcher : MonoBehaviour
{
    public Button InstrumentMuteButton;
    public Button InstrumentUnmuteButton;

    void Start()
    {
        InstrumentMuteButton.gameObject.SetActive(true);
        InstrumentUnmuteButton.gameObject.SetActive(false);
        InstrumentMuteButton.onClick.AddListener(OnInstrumentMuteClick);
    }

    void OnInstrumentMuteClick()
    {
        InstrumentMuteButton.gameObject.SetActive(false);
        InstrumentUnmuteButton.gameObject.SetActive(true);
        InstrumentMuteButton.onClick.RemoveListener(OnInstrumentMuteClick);
        InstrumentUnmuteButton.onClick.AddListener(OnInstrumentUnmuteClick);
    }

    void OnInstrumentUnmuteClick()
    {
        InstrumentUnmuteButton.gameObject.SetActive(false);
        InstrumentMuteButton.gameObject.SetActive(true);
        InstrumentUnmuteButton.onClick.RemoveListener(OnInstrumentUnmuteClick);
        InstrumentMuteButton.onClick.AddListener(OnInstrumentMuteClick);
    }
}