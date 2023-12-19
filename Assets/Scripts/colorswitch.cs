using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorswitch : MonoBehaviour
{
    private MeshRenderer  mesh;
    [SerializeField] private AudioClip clipSfx;
    private AudioSource audioSource;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

  public void SwitchColor()
  {
  mesh.material.color = Color.red;
  audioSource.PlayOneShot(clipSfx);
  StartCoroutine(ColorBack());
  
  }

  IEnumerator ColorBack(){
    yield return new WaitForSeconds (0.5f);
    mesh.material.color = Color.white;
  }
}
