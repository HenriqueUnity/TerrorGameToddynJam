using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorUpDown : MonoBehaviour
{
    private Vector3 initialPosition;
    [SerializeField] private Transform closePosition;
    bool doorState;
    void Start()
    {
      initialPosition = transform.position;  
      
    }

    
    
    public void CloseDoor(){  
        if(!doorState){
          transform.position = closePosition.transform.position;
          doorState = true;
        }
        else{
            transform.position = initialPosition;
            doorState = false;
        }

        Debug.Log(doorState);

    }
}
