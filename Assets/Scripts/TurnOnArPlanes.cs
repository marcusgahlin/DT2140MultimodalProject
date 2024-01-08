using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

//using UnityEngine.XR.Interaction.Toolkit.AR;

public class TurnOnArPlanes : MonoBehaviour
{
    [SerializeField]
    private bool planesAreOn = false;

    [SerializeField]
    public GameObject ARSessionOr;

    [SerializeField]
    public Button test;

    // Start is called before the first frame update
    void Start()
    {
        ARSessionOr = GameObject.Find("AR Session Origin");
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
}
