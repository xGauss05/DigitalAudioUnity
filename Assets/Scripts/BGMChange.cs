using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BGMChange : MonoBehaviour
{
    public AudioMixerSnapshot baseSnapshot;
    public AudioMixerSnapshot nearSnapshot;
    public AudioMixerSnapshot indoorSnapshot;

    public float slowTransitionTime = 2.0f;
    public float fastTransitionTime = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Near":
                nearSnapshot.TransitionTo(slowTransitionTime);
                break;

            case "Indoor":
                indoorSnapshot.TransitionTo(fastTransitionTime);
                break;

            default:
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Near":
                baseSnapshot.TransitionTo(slowTransitionTime);
                break;

            case "Indoor":
                nearSnapshot.TransitionTo(slowTransitionTime);
                break;

            default:
                break;
        }
    }
}
