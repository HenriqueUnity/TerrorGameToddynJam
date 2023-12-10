using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchLimiter : MonoBehaviour
{
 

    
   private GameObject jogador;
    
    public float distanciaDeDetecao = 0.5f;
    
   
    void Start()
    {
     jogador = GameObject.Find("player");
    }
    private void Update()
    {
        // Obtém a posição do jogador
        Vector3 posicaoDoJogador = ObterPosicaoDoJogador();

        // Calcula a distância entre o objeto e o jogador
        float distancia = Vector3.Distance(transform.position, posicaoDoJogador);

        // Verifica se o jogador está dentro da distância de detecção
        if (distancia < distanciaDeDetecao )
        {
           
        jogador.GetComponentInChildren<crouch>().enabled = false;   
        }else{
            jogador.GetComponentInChildren<crouch>().enabled = true;  
        }
    }

    private Vector3 ObterPosicaoDoJogador()
    {       

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
