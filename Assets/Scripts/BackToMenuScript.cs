using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenuScript : MonoBehaviour
{
    [SerializeField]
    public GameObject backButton;
    // Start is called before the first frame update
    public void GoBackToMenu(){
        //backButton.SetActive(false);
        //SceneManager.UnloadSceneAsync("Buttons");
        SceneManager.LoadScene("EmptyScene");
    }

    public void ShowGoBackButton(){
        backButton.SetActive(true);
    }
}
