using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinotriiger : MonoBehaviour
{
   [SerializeField] private GameObject enemy;
   [SerializeField] private float distanceDeDetecao= 2f;
 
    private void Update()
    {
        
        Vector3 playerPosition = GetplayerPosition();

        
        float distance = Vector3.Distance(transform.position, playerPosition);

       
        if (distance < distanceDeDetecao && Input.GetKeyDown(KeyCode.E))
        {
            if(!enemy.activeInHierarchy){
           ActiveEnemy();
            }
        }
    }

    private Vector3 GetplayerPosition()
    {
        // Certifique-se de substituir "NomeDoplayer" pelo nome real do GameObject do player
        GameObject player = GameObject.Find("player");

        if (player != null)
        {
            // Obtém o CharacterController do player
            CharacterController characterController = player.GetComponent<CharacterController>();

            // Retorna a posição do player (pode ser o centro do CharacterController ou a posição da cabeça, dependendo do seu jogo)
            return characterController != null ? characterController.transform.position : player.transform.position;
        }

        return Vector3.zero; // Retorna (0, 0, 0) se o player não for encontrado
    }

    // Update is called once per frame
    private void ActiveEnemy(){
        enemy.gameObject.SetActive(true);
    }
}
