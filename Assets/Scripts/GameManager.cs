using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   [SerializeField]private int sceneToload;
   [SerializeField]private float detectionDistance= 1f;

   private GameObject player;
    void Start()
    {
        player =  GameObject.Find("player");
    }

    public void GameOver(){
     SceneManager.LoadScene(0);
    }

     private void Update()
    {
      
        Vector3 playerPosition = GetPlayerPosition();

      
        float distancia = Vector3.Distance(transform.position, playerPosition);

     
        if (distancia < detectionDistance  && Input.GetKeyDown(KeyCode.E))
        {
           NextScene();     
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

    public void NextScene(){
        SceneManager.LoadScene(sceneToload);
    }
}
