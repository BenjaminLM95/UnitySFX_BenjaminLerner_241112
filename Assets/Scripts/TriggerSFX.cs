using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource auso;
    public AudioClip aucl; 
    // Start is called before the first frame update
    void Start()
    {
        auso = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            auso.clip = aucl;
            auso.Play(); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            auso.clip = aucl;
            auso.Pause();
        }
    }
}
