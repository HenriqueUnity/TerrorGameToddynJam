using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorUpDown : MonoBehaviour
{
    private Vector3 initialPosition;
    [SerializeField] private Transform closePosition;
    bool doorState;
    bool coolDown;
    
    float speed = 2;
    void Start()
    {
      initialPosition = transform.position;  
      
    }

   
    
    
    public void CloseDoor(){  

         
 StartCoroutine(DoorCoolDown(2f));
 if(!coolDown)
  {
    coolDown= true;
    if(!doorState )
    {         
     StartCoroutine(SmoothMove(initialPosition,closePosition.position,speed));
     doorState = true;
    }
    else{
     StartCoroutine(SmoothMove(closePosition.position,initialPosition,speed));
    doorState = false;
        }

  }    
     
    }
    private IEnumerator SmoothMove(Vector3 start, Vector3 end, float speed)
    {
        float t = 0f;
        while (t < 1.0f)
        {
            t += Time.deltaTime * (speed / Vector3.Distance(start, end));
            transform.position = Vector3.Lerp(start, end, Mathf.SmoothStep(0f, 1f, t));
            yield return null;
        }
    }
    private IEnumerator DoorCoolDown(float time){
    yield return new WaitForSeconds(time);
    coolDown = false;
    }
}
