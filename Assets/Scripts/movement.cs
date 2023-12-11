using UnityEngine;

public class movement : MonoBehaviour
{
   private Vector3 playerInput;
   private CharacterController characterController;
   [SerializeField] private float speed;
   [SerializeField] private float standartSpeed = 3f;
   [SerializeField] private float sprintSpeed = 6f;
   private Transform myCamera;
   
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        myCamera = Camera.main.transform;
        speed = standartSpeed;
      
    }

    void Update()
    {
     
     transform.eulerAngles = new Vector3(transform.eulerAngles.x,myCamera.eulerAngles.y,transform.eulerAngles.z); 
     playerInput = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
     playerInput = transform.TransformDirection(playerInput);
     characterController.Move(playerInput * Time.deltaTime * speed) ;   
    
    }

    bool CrouchBool(){
     return GetComponentInChildren<crouch>().CrouchingState;
    }
    void LateUpdate()
    {
          if(Input.GetKey(KeyCode.R) && !CrouchBool())
     {        
      speed = sprintSpeed;
     }
     if(Input.GetKeyUp(KeyCode.R)){
      speed = standartSpeed;
     }   
    }

    

        
}
