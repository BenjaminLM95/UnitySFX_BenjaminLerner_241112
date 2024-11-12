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
        music2 = false; 
        audioSource.clip = song1;
        audioSource.Play(); 
    }

    public void playSong1() 
    {
        audioSource.clip = song1;
        audioSource.volume = 0.5f;
        audioSource.Play();
    }

    public void playSong2()
    {

        audioSource.clip = song2;
        audioSource.volume = 0.25f;
        audioSource.Play();
    }
       
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (music1)
            {
                audioSource.Pause();
                playSong2();
                music1 = false;
                music2 = true; 
            }
            else if (music2) 
            {
                audioSource.Pause();
                playSong1();
                music1 = true;
                music2 = false;
            }
            else 
            {
                audioSource.Pause(); 
            }
        }
    }

    
}

    


