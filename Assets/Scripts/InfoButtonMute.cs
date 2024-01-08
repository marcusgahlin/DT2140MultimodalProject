using UnityEngine;
using UnityEngine.UI;

public class InfoButtonMute : MonoBehaviour
{
    public GameObject button;
    public Button startButton;

    void Start()
    {
        startButton.onClick.AddListener(StartTimer);
    }

    void StartTimer()
    {   button.SetActive(false);
        Invoke("ShowButton", 15.0f);
        Invoke("HideButton", 25.0f);
    }

    void HideButton()
    {
        button.SetActive(false);
    }

    void ShowButton()
    {
        button.SetActive(true);
    }
}