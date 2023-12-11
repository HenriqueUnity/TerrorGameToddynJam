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
    private CharacterController m_Controller;

    public bool CrouchingState;
    void Start()
    {
firstPov = GameObject.Find("Pov").gameObject;
 myCam = GameObject.Find("Virtual Camera").GetComponent<CinemachineVirtualCamera>();
  m_Controller = GetComponentInParent<CharacterController>();      
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

      
        if(!isCrouched )
         {
       isCrouched = true;
       CrouchingState = isCrouched;
       Debug.Log("crouch"+ CrouchingState);
       myCam.Follow = gameObject.transform; 
       m_Controller.height = 1;
       m_Controller.center = new Vector3(0,-0.5f,0);
       
         }else{
            isCrouched = false;
           CrouchingState = isCrouched;
           Debug.Log("crouch"+ CrouchingState);
            myCam.Follow = firstPov.transform;
            m_Controller.height = 2;
             m_Controller.center = Vector3.zero;

        }

      
     
    }


}
