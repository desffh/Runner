using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    [SerializeField] AudioSource effectAudioSource;
    [SerializeField] AudioSource sceneryAudioSource;

    public void Listen(AudioClip audioClip)
    {
        // effectAudioSource.clip = audioClip;
        effectAudioSource.PlayOneShot(audioClip);
    }
}
