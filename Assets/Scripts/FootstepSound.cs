using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioClip[] footstepsOnBush;
    public AudioClip[] footstepsOnRock;
    public AudioClip[] footstepsOnGravel;
    public AudioClip[] footstepsOnGrass;
    public AudioClip[] footstepsOnWater;
    public AudioClip[] footstepsOnWood;

    public string material;

    void PlayFootstepSound()
    {
        AudioSource myAudioSource = GetComponent<AudioSource>();
        myAudioSource.volume = Random.Range(0.9f, 1.0f);
        myAudioSource.pitch = Random.Range(0.8f, 1.2f);

        switch (material)
        {
            case "Bush":
                myAudioSource.PlayOneShot(footstepsOnBush[Random.Range(0, footstepsOnBush.Length)]);
                break;
            case "Rock":
                myAudioSource.PlayOneShot(footstepsOnRock[Random.Range(0, footstepsOnRock.Length)]);
                break;
            case "Gravel":
                myAudioSource.PlayOneShot(footstepsOnGravel[Random.Range(0, footstepsOnGravel.Length)]);
                break;
            case "Grass":
                myAudioSource.PlayOneShot(footstepsOnGrass[Random.Range(0, footstepsOnGrass.Length)]);
                break;
            case "Water":
                myAudioSource.PlayOneShot(footstepsOnWater[Random.Range(0, footstepsOnWater.Length)]);
                break;
            case "Wood":
                myAudioSource.PlayOneShot(footstepsOnWood[Random.Range(0, footstepsOnWood.Length)]);
                break;
            default:
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        material = collision.gameObject.tag;
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Collision with" + other.gameObject.tag);
        material = other.gameObject.tag;
    }
}
