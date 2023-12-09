using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Unity.VisualScripting;
using UnityEngine;

public class crouch : MonoBehaviour
{
    public CinemachineVirtualCamera myCam;
    bool isCrouched; 
    private GameObject firstPov;
    void Start()
    {
firstPov = GameObject.Find("Pov").gameObject;
 myCam = GameObject.Find("Virtual Camera").GetComponent<CinemachineVirtualCamera>();
        
    }

    

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.C))
     {
      Crouching();
     }



        
    }

    void Crouching(){
     if(!isCrouched)
         {
       myCam.Follow = gameObject.transform; 
       isCrouched = true;
         }
    else{
            myCam.Follow = firstPov.transform;
            isCrouched = false;

        }
    }
}
