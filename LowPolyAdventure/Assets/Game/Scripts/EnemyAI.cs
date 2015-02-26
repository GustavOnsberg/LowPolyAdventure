using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    public float attackDist = 3;
    Transform player;
    NavMeshAgent nav;

	void Start ()
    {
	    nav = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	void Update () 
    {
        nav.SetDestination(player.position);

        if (Vector3.Distance(transform.position, player.position) < attackDist)
            print("attacking");
    }
}
