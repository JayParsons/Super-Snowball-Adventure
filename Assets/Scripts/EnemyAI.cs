using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {

    Transform player;         
    private NavMeshAgent nav;

    // Use this for initialization
    void Awake () {
        //This was supposed to make the enemy characters chase the player
        //However, it did not work. Ran out of time to get it working
        //by the deadline.
        player = GameObject.FindGameObjectWithTag("Snowman2").transform;
        nav = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
           nav.SetDestination(player.position);
    }
}
