using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using System;

public class ARPlaneTracker : MonoBehaviour
{
    [SerializeField]
    private ARPlaneManager _ARPlaneManager;

    // [SerializeField]
    // public event Action<ARPlanesChangedEventArgs> planesChanged;

    [SerializeField]
    public bool instructionsHaveChanged;
    [SerializeField]
    public GameObject instructionsMoveCamera;
    [SerializeField]
    public GameObject instructionsTap;

    // Start is called before the first frame update
    void Start()
    {
        _ARPlaneManager = GameObject.Find("AR Session Origin").GetComponent<ARPlaneManager>();
        instructionsHaveChanged = false;
        //_ARPlaneManager.planesAdded.AddListener(ChangeInstructions);
        _ARPlaneManager.planesChanged += ChangeInstructions;
        // planesChanged.AddListener(ChangeInstructions);
    }

    // Update is called once per frame
    void Update()
    {

    }



    void ChangeInstructions(ARPlanesChangedEventArgs eventArgs)
    {
        // This function is triggered when changes in the scanned planes are noticed
        // When this happens we change the type of instruction and also remove the event listener
        if (!instructionsHaveChanged)
        {
            instructionsHaveChanged = true;
            _ARPlaneManager.planesChanged -= ChangeInstructions;
            Invoke("ChangeInstructionsCallback", 2.0f);
            //GameObject.Find("Canvas/InformationButtonMove").SetActive(false);
            //GameObject.Find("Canvas/InformationButtonTap").SetActive(true);
        }
    }

    void ChangeInstructionsCallback()
    {
        instructionsMoveCamera.SetActive(false);
        instructionsTap.SetActive(true);
        //planesChanged.RemoveListener(ChangeInstructions);
    }
}
