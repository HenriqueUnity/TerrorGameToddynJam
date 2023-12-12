using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class Enemy : MonoBehaviour
{
   private NavMeshAgent navMesh;
   private GameObject player;
   [SerializeField] private float speed;
   [SerializeField] private float lethalDistance = 1.7f;
   private GameManager gm;
    void Start()
    {
        navMesh= GetComponent<NavMeshAgent>();
        player = GameObject.Find("player");
        navMesh.speed = speed;
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

   
    void Update()
    {
        navMesh.destination = player.transform.position;
        if(Vector3.Distance(transform.position,player.transform.position ) < lethalDistance){
            gm.GameOver();
        }
    }
}
