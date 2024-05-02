using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioClip[] footstepsOnGrass;
    public AudioClip[] footstepsOnWood;
    public AudioClip[] footstepsOnBush;

    void PlayFootstepSound()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        AudioSource myAudioSource = GetComponent<AudioSource>();
        myAudioSource.volume = Random.Range(0.9f, 1.0f);
        myAudioSource.pitch = Random.Range(0.8f, 1.2f);

        switch (collision.gameObject.tag)
        {
            case "Grass":
                myAudioSource.PlayOneShot(footstepsOnGrass[Random.Range(0, footstepsOnGrass.Length)]);
                break;

            case "Wood":
                myAudioSource.PlayOneShot(footstepsOnWood[Random.Range(0, footstepsOnWood.Length)]);
                break;
            case "Bush":
                myAudioSource.PlayOneShot(footstepsOnBush[Random.Range(0, footstepsOnBush.Length)]);
                break;

            default:
                break;
        }
    }
}
