using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTimeDoor : MonoBehaviour
{
    private door_Button button;
    void Start()
    {
        button = GetComponent<door_Button>();
    }

  public void DeactiveButton(){
    button.enabled=false;
  }
}
