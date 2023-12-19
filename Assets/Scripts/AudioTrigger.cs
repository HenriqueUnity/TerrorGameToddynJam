using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    private AudioSource audioClip;
    void Start()
    {
        audioClip = GetComponent<AudioSource>();
    }

  
   void OnTriggerEnter(Collider other)
   {
       audioClip.Play();
   }
}
