using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class door_Button : MonoBehaviour
{

    [SerializeField] private GameObject doorToInteract;
    private colorswitch colorSwitch;
    public float distanceDeDetecao = 3f;
    
    void Start(){
   colorSwitch = GetComponent<colorswitch>();
    }
    private void Update()
    {
        // Obtém a posição do player
        Vector3 playerPosition = GetplayerPosition();

        // Calcula a distância entre o objeto e o player
        float distance = Vector3.Distance(transform.position, playerPosition);

        // Verifica se o player está dentro da distância de detecção
        if (distance < distanceDeDetecao && Input.GetKeyDown(KeyCode.E))
        {
            colorSwitch.SwitchColor();
            doorToInteract.GetComponent<doorUpDown>().CloseDoor();
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
}
