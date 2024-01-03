using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isMuted = false;

    public float scaleMultiplier = 1.0f;

    private Vector3 originalScale;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        originalScale = transform.localScale;

    }

    void Update()
    {
        if (!isMuted)
        {
            audioData();
            scaleUpdate();
        }
        else
        {
            transform.localScale = originalScale;
        }

        // if (Input.GetMouseButtonDown(0))
        // {
        //     RaycastHit hit;
        //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //     if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
        //     {
        //         Mute();
        //     }
        // }
    }

    public void Mute()
    {
        isMuted = !isMuted;
        audioSource.mute = isMuted;
    }

    void audioData()
    {
        float[] spectrumData = new float[256];

        audioSource.GetSpectrumData(spectrumData, 0, FFTWindow.Hamming);

        float audioLevel = 0f;

        for (int i = 0; i < spectrumData.Length; i++)
        {
            audioLevel += spectrumData[i];
        }
        audioLevel /= spectrumData.Length;

        scaleMultiplier = 1.0f + audioLevel * 200f;
    }

    void scaleUpdate()
    {
        transform.localScale = originalScale * scaleMultiplier;
    }
}



