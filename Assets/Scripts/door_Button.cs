using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_Button : MonoBehaviour
{

    [SerializeField] private GameObject doorToInteract;
    
    public float distanciaDeDetecao = 3f;
    
    
    private void Update()
    {
        // Obtém a posição do jogador
        Vector3 posicaoDoJogador = ObterPosicaoDoJogador();

        // Calcula a distância entre o objeto e o jogador
        float distancia = Vector3.Distance(transform.position, posicaoDoJogador);

        // Verifica se o jogador está dentro da distância de detecção
        if (distancia < distanciaDeDetecao && Input.GetKeyDown(KeyCode.E))
        {
            // O jogador está próximo, faça algo aqui
            doorToInteract.GetComponent<doorUpDown>().CloseDoor();
        }
    }

    private Vector3 ObterPosicaoDoJogador()
    {
        // Certifique-se de substituir "NomeDoJogador" pelo nome real do GameObject do jogador
        GameObject jogador = GameObject.Find("player");

        if (jogador != null)
        {
            // Obtém o CharacterController do jogador
            CharacterController characterController = jogador.GetComponent<CharacterController>();

            // Retorna a posição do jogador (pode ser o centro do CharacterController ou a posição da cabeça, dependendo do seu jogo)
            return characterController != null ? characterController.transform.position : jogador.transform.position;
        }

        return Vector3.zero; // Retorna (0, 0, 0) se o jogador não for encontrado
    }
}
