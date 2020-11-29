using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventHandler : MonoBehaviour
{

    [Header("Audio Events")]
    public AudioSource MovementAudioSource; //The audio source on the player for abilities
    //public AudioSource DiveAudioSource; //A separate audio source on the player for diving so it doesn't cut out when another animation plays.
    public AudioClip[] footstepsclips;
    [Header("Particle Events")]
    public ParticleSystem particlesyssteps; //Particle system which emits at footsteps


    public void Footstep()
    {
        MovementAudioSource.clip = footstepsclips[Random.Range(0, footstepsclips.Length)];
        if (!MovementAudioSource.isPlaying)
        {
            MovementAudioSource.Play();
        }
        particlesyssteps.Play();
    }
}
