using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Audio : MonoBehaviour
{
    public Observer observer;
    //public List<AudioClip> MyAudioClips;
    public AudioClip Beep;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    [ContextMenu ("Play Beep")]
    void PlayAudio()
    {
        audio.PlayOneShot(Beep, 0.7f);
    }
}
