using UnityEngine;
using System.Collections.Generic;

public class AudioSensor : MonoBehaviour
{
    public AudioSource microphoneAudio;
    public float detectionRadius = 20f;

    public float GetSoundLevel()
    {
        if (microphoneAudio == null)
            return 0f;

        return microphoneAudio.volume;
    }

    public bool DetectSound(float threshold)
    {
        return GetSoundLevel() >= threshold;
    }
}