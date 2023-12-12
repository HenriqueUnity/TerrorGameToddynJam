using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ductEnterExit : MonoBehaviour
{
      
   private GameObject player;
    
    public float detectionDistance = 0.5f;
    
   
    void Start()
    {
     player = GameObject.Find("player");
    }
    private void Update()
    {
      
        Vector3 playerPosition = GetPlayerPosition();

      
        float distancia = Vector3.Distance(transform.position, playerPosition);

        if (distancia < detectionDistance && Input.GetKeyDown(KeyCode.E))
        {
           gameObject.SetActive(false);
        }
    }

    private Vector3 GetPlayerPosition()
    {       

        if (player != null)
        {
          
            CharacterController characterController = player.GetComponent<CharacterController>();

            return characterController != null ? characterController.transform.position : player.transform.position;
        }

        return Vector3.zero;
    }
}
