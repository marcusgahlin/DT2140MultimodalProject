using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoButtonVisible : MonoBehaviour
{
    public GameObject button;
    public Button startButton;

    void Start()
    {
        button.SetActive(false);
        startButton.onClick.AddListener(StartTimer);
    }

    void StartTimer()
    {
        button.SetActive(true); 
        Invoke("HideButton", 10.0f); 
    }

    void HideButton()
    {
        button.SetActive(false); 
    }
}