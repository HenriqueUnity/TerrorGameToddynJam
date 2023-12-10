using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
   private Vector3 playerInput;
   private CharacterController characterController;
   [SerializeField] float speed = 5f;
   private Transform myCamera;
   
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        myCamera = Camera.main.transform;
        

    }

    // Update is called once per frame
    void Update()
    {
    transform.eulerAngles = new Vector3(transform.eulerAngles.x,myCamera.eulerAngles.y,transform.eulerAngles.z); 
    playerInput = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
    playerInput = transform.TransformDirection(playerInput);
    characterController.Move(playerInput * Time.deltaTime * speed) ;   
    }

        
}
