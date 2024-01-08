using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConnectSliders : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public GameObject SliderThreshold;

    [SerializeField]
    public TMP_Text MeterThreshold;

    [SerializeField]
    public GameObject SliderCutoff;

    [SerializeField]
    public TMP_Text MeterCutoff;

    [SerializeField]
    public GameObject SliderDurationMultiplier;

    [SerializeField]
    public TMP_Text MeterDurationMul;

    [SerializeField]
    private GameObject instrumentObject;

    private SoundHapticFeedback _hapticFeedback;
    void Start()
    {
        instrumentObject = GameObject.Find("Instruments 1 macke(Clone)");
        _hapticFeedback = instrumentObject.transform.GetChild(1).GetChild(0).GetChild(0).gameObject.GetComponent<SoundHapticFeedback>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SliderThresholdChanged(float value)
    {
        _hapticFeedback.detectionThreshold = value;
        // MeterThreshold.GetComponent<UnityEngine.UI.Text>().text = value.ToString();
        MeterThreshold.text = value.ToString();
    }

    public void SliderCutoffChanged(float value)
    {
        _hapticFeedback.cutoffFrequency = value;
        //MeterCutoff.GetComponent<UnityEngine.UI.Text>().text = value.ToString();
        MeterCutoff.text = value.ToString();
    }

    public void SliderDurationMultiplierChanged(float value)
    {
        _hapticFeedback.durationMultiplier = value;
        //MeterDurationMul.GetComponent<UnityEngine.UI.Text>().text = value.ToString();
        MeterDurationMul.text = value.ToString();
    }
}
