using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicAudioSource;
    public AudioSource vfxAudioSource;

    public AudioClip musicClip;
    public AudioClip coinClip;
    public AudioClip winClip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        musicAudioSource.clip = musicClip;
        musicAudioSource.Play();
    }
}
