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
    void Start()
    {
        navMesh= GetComponent<NavMeshAgent>();
        player = GameObject.Find("player");
        navMesh.speed = speed;
    }

   
    void Update()
    {
        navMesh.destination = player.transform.position;
        if(Vector3.Distance(transform.position,player.transform.position ) < 2f){
                //atacar
        }
    }
}
