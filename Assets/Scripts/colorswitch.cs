using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorswitch : MonoBehaviour
{
    private MeshRenderer  mesh;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

  public void SwitchColor()
  {
  mesh.material.color = Color.red;
  StartCoroutine(ColorBack());
  
  }

  IEnumerator ColorBack(){
    yield return new WaitForSeconds (0.5f);
    mesh.material.color = Color.white;
  }
}
