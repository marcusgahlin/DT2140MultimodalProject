using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class MuteScriptCustom : MonoBehaviour
{
    //public ARPlacementInteractable placementInteractable; // Assign this in the inspector
    //public Button yourButton; // Assign this in the inspector
    private GameObject instantiatedInstruments;
    //private AudioSource _audioSource;
    // [SerializeField]
    // private int childInstrumentIndex;
    [SerializeField]
    private AudioSource pianoAudioSource;
    [SerializeField]
    private AudioSource drumsAudioSource;
    [SerializeField]
    private AudioSource guitarAudioSource;
    [SerializeField]
    private AudioSource bassAudioSource;
    [SerializeField]
    private AudioSource vocAudioSource;

    // Buttons

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


    // Start is called before the first frame update
    void Start()
    {
        // Add a listener to the button to call the 'OnButtonPressed' method when clicked
        instantiatedInstruments = GameObject.Find("Instruments 1 macke(Clone)");
        // pianoAudioSource = instantiatedInstruments.transform.Find("PianoParent/Cube/keyboard").gameObject.GetComponent<AudioSource>();
        // drumsAudioSource = instantiatedInstruments.transform.Find("DrumsParent/Cube/Drum set").gameObject.GetComponent<AudioSource>();
        // guitarAudioSource = instantiatedInstruments.transform.Find("GuitarParent/Cube/model").gameObject.GetComponent<AudioSource>();
        // bassAudioSource = instantiatedInstruments.transform.Find("BassParent/Cube/GAP_F_Mazet_Lennon_Lowpoly").gameObject.GetComponent<AudioSource>();
        // vocAudioSource = instantiatedInstruments.transform.Find("MicrophoneParent/Cube/Microphone").gameObject.GetComponent<AudioSource>();
        pianoAudioSource = instantiatedInstruments.transform.GetChild(0).GetChild(0).GetChild(0).gameObject.GetComponent<AudioSource>();
        drumsAudioSource = instantiatedInstruments.transform.GetChild(1).GetChild(0).GetChild(0).gameObject.GetComponent<AudioSource>();
        guitarAudioSource = instantiatedInstruments.transform.GetChild(4).GetChild(0).GetChild(0).gameObject.GetComponent<AudioSource>();
        bassAudioSource = instantiatedInstruments.transform.GetChild(3).GetChild(0).GetChild(0).gameObject.GetComponent<AudioSource>();
        vocAudioSource = instantiatedInstruments.transform.GetChild(2).GetChild(0).GetChild(0).gameObject.GetComponent<AudioSource>();

        // yourButton.onClick.AddListener(OnButtonPressed);
 
    }

    public void OnButtonPressed(AudioSource _audioSource)
    {
        // mute/unmute audio
        // _audioSource = instantiatedInstruments.transform.GetChild(childInstrumentIndex).GetChild(0).GetChild(0).gameObject.GetComponent<AudioSource>();
        if (_audioSource.mute == true)
        {
            _audioSource.mute = false;
        } else
        {
            _audioSource.mute = true;
        }

        // else
        // {
        //     Debug.Log("No object has been placed yet or reference is missing.");
        // }
    }

    public void ButtonSwitcher(string instrument)
    {
        switch (instrument)
        {
            case "piano":
                OnButtonPressed(pianoAudioSource);
                break;

            case "drums":
                OnButtonPressed(drumsAudioSource);
                break;

            case "guitar":
                OnButtonPressed(guitarAudioSource);
                break;

            case "bass":
                OnButtonPressed(bassAudioSource);
                break;

            case "voc":
                OnButtonPressed(vocAudioSource);
                break;

        }
    }
}