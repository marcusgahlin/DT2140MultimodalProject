using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class PauseScript : MonoBehaviour
{
    //public ARPlacementInteractable placementInteractable; // Assign this in the inspector
    public Button yourButton; // Assign this in the inspector
    private GameObject instantiatedInstruments;
    private AudioSource _audioSource;
    [SerializeField]
    private int childInstrumentIndex;


    // Start is called before the first frame update
    void Start()
    {
        // Add a listener to the button to call the 'OnButtonPressed' method when clicked
        instantiatedInstruments = GameObject.Find("Instruments 1 macke(Clone)");
        
        yourButton.onClick.AddListener(OnButtonPressed);
 
    }

    void OnButtonPressed()
    {
        // mute/unmute audio
        _audioSource = instantiatedInstruments.transform.GetChild(childInstrumentIndex).GetChild(0).GetChild(0).gameObject.GetComponent<AudioSource>();
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

    // Update is called once per frame
    void Update()
    {
        
    }
}