using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public AudioClip song1;
    public AudioClip song2;

    private AudioSource audioSource;
    private bool paused1;
    private bool paused2;
    private bool music1;
    private bool music2; 

    // both songs are in paused state
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        music1 = true; 
        audioSource.clip = song1;
        audioSource.Play(); 
    }

    

}
