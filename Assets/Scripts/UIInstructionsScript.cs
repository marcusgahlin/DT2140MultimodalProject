using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInstructionsScript : MonoBehaviour
{
    [SerializeField]
    public GameObject playInstructions;

    [SerializeField]
    public GameObject moveAroundInstructions;

    [SerializeField]
    public GameObject moveInstrumentsInstructions;

    private bool instructionsWereShown;

    // Start is called before the first frame update
    void Start()
    {
        instructionsWereShown = false;
        Invoke("ShowPlayInstructions", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowPlayInstructions(){
        playInstructions.SetActive(true);
    }

    public void HidePlayInstructions(){
        if (!instructionsWereShown) {
            playInstructions.SetActive(false);
            Invoke("ShowMoveAroundInstructions", 5.0f);
            instructionsWereShown = true;
        }
    }

    public void ShowMoveAroundInstructions(){
        moveAroundInstructions.SetActive(true);
        //Invoke("HideMoveAroundInstructions", 3.0f);
    }

    public void HideMoveAroundInstructions(){
        moveAroundInstructions.SetActive(false);
        Invoke("ShowMoveInstrumentsInstructions", 0.5f);
    }

    public void ShowMoveInstrumentsInstructions(){
        moveInstrumentsInstructions.SetActive(true);
        //Invoke("ShowMoveInstrumentsInstructions", 3.0f);
    }

    public void HideMoveInstrumentsInstructions(){
        moveInstrumentsInstructions.SetActive(false);
    }
}
