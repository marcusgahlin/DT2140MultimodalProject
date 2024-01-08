using UnityEngine;
using UnityEngine.UI;


public class InfoButtonMove : MonoBehaviour
{
    public GameObject button;
    public Button startButton;

    void Start()
    {
        startButton.onClick.AddListener(StartTimer);
    }

    void StartTimer()
    {   button.SetActive(false);
        Invoke("ShowButton", 10.0f);
        Invoke("HideButton", 20.0f);
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