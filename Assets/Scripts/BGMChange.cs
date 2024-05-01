using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BGMChange : MonoBehaviour
{
    public AudioMixerSnapshot baseSnapshot;
    public AudioMixerSnapshot calmSnapshot;
    public AudioMixerSnapshot combatSnapshot;

    public float slowTransitionTime = 2.0f;
    public float fastTransitionTime = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Tension":
                calmSnapshot.TransitionTo(slowTransitionTime);
                break;

            case "Indoor":
                combatSnapshot.TransitionTo(fastTransitionTime);
                break;

            default:
                break;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Tension":
                baseSnapshot.TransitionTo(slowTransitionTime);
                break;

            case "Indoor":
                calmSnapshot.TransitionTo(slowTransitionTime);
                break;

            default:
                break;
        }
    }
}
