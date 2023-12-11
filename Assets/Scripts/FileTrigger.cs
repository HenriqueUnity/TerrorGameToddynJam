using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileTrigger : MonoBehaviour
{
    [SerializeField]private File fileToRead;
    private InteractableText UiManager;
    public string fileContent;
    public float distanciaDeDetecao = 3f;
    void Start()
    {
      fileContent = fileToRead.fileContent;  
      UiManager = GameObject.Find("UIManager").GetComponent<InteractableText>();
    }

    
    
    private void Update()
    {
        // Obtém a posição do jogador
        Vector3 posicaoDoJogador = ObterPosicaoDoJogador();

        // Calcula a distância entre o objeto e o jogador
        float distancia = Vector3.Distance(transform.position, posicaoDoJogador);

        // Verifica se o jogador está dentro da distância de detecção
        if (distancia < distanciaDeDetecao && Input.GetKeyDown(KeyCode.E))
        {
            
           UiManager.FileRead(fileContent);
        }
    }

    private Vector3 ObterPosicaoDoJogador()
    {
        // Certifique-se de substituir "NomeDoJogador" pelo nome real do GameObject do jogador
        GameObject player = GameObject.Find("player");

        if (player != null)
        {
            // Obtém o CharacterController do jogador
            CharacterController characterController = player.GetComponent<CharacterController>();

            // Retorna a posição do jogador (pode ser o centro do CharacterController ou a posição da cabeça, dependendo do seu jogo)
            return characterController != null ? characterController.transform.position : player.transform.position;
        }

        return Vector3.zero; // Retorna (0, 0, 0) se o jogador não for encontrado
    }
   
}
