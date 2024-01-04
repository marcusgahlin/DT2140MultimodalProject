using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.iOS;

[RequireComponent(typeof(AudioSource))]
public class SoundHapticFeedback : MonoBehaviour
{
    public float detectionThreshold = 0.5f;
    public float vibrationIntensityMultiplier = 2f;

    private AudioLowPassFilter lowPassFilter;

    public AudioSource audioSource;
    public float cutoffFrequency = 100f;

    // Low-pass filter parameters
    private float filterConstant;
    private float previousSample = 0f;

    void Start()
    {
        // Attach an AudioSource component to the GameObject
        audioSource = GetComponent<AudioSource>();

        // Start playing the audio
        audioSource.Play();

        float dt = 1f / AudioSettings.outputSampleRate;
        float RC = 1f / (cutoffFrequency * 2 * Mathf.PI);
        filterConstant = dt / (dt + RC);
    }

    void Update()
    {
        // Continuously check for sound events during playback
        DetectSoundEvent();
    }

    float[] ApplyLowPassFilter(float[] samples)
    {
        float[] filteredSamples = new float[samples.Length];

        for (int i = 0; i < samples.Length; i++)
        {
            // Apply simple low-pass filter
            filteredSamples[i] = previousSample + filterConstant * (samples[i] - previousSample);
            previousSample = filteredSamples[i];
        }

        return filteredSamples;
    }


    void DetectSoundEvent()
    {
        // Get audio samples from the AudioSource
        float[] samples = new float[1024]; // Adjust the size based on your needs
        audioSource.GetOutputData(samples, 0);

        // Apply the filter to the samples
        float[] filteredSamples = ApplyLowPassFilter(samples);

        // Calculate the RMS (Root Mean Square) amplitude of the filtered samples
        float rmsAmplitude = CalculateRMSAmplitude(filteredSamples);

        // Adjust the detection threshold based on the volume level
        float adjustedThreshold = detectionThreshold * vibrationIntensityMultiplier;

        // Compare the volume level with the adjusted threshold
        if (rmsAmplitude > adjustedThreshold)
        {
            // Trigger haptic feedback based on volume level
            TriggerHapticFeedback(rmsAmplitude);
        }
    }

    float CalculateRMSAmplitude(float[] samples)
    {
        float sum = 0f;

        foreach (float sample in samples)
        {
            sum += sample * sample;
        }

        float rms = Mathf.Sqrt(sum / samples.Length);
        return rms;
    }

    void TriggerHapticFeedback(float intensity)
    {
        // Platform-specific haptic feedback
        // #if UNITY_IOS
        //     // Scale the intensity for Taptic Engine feedback
        //     int feedbackIntensity = Mathf.RoundToInt(intensity * 10);
        //     Device.TapticImpact((TapticFeedbackImpactStyle)feedbackIntensity);
        #if UNITY_ANDROID
            // Scale the intensity for Android vibration duration
            long duration = Mathf.RoundToInt(intensity * 0.0001f);
            Handheld.Vibrate();
        #endif
    }
}
