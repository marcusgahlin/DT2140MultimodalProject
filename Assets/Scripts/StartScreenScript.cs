using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class StartScreenScript : MonoBehaviour
{
    [SerializeField]
    public GameObject startScreen;

    [SerializeField]
    public GameObject moveCameraScreen;

    [SerializeField]
    private bool planesAreOn = false;

    [SerializeField]
    public GameObject ARSessionOr;

    [SerializeField]
    public GameObject informationScreen;


    // Start is called before the first frame update
    void Start()
    {
        //Invoke("SwitchScreens", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOnPlanes(){
        if (!planesAreOn)
        {
            ARSessionOr.GetComponent<ARPlaneManager>().enabled = true;
            ARSessionOr.GetComponent<ARPlaneTracker>().enabled = true;
            planesAreOn = true;
        }
    }

    public void SwitchScreens(){
        startScreen.SetActive(false);
        moveCameraScreen.SetActive(true);
        TurnOnPlanes();

    }

    public void CloseInformationScreen(){
        informationScreen.SetActive(false);
    }
}
