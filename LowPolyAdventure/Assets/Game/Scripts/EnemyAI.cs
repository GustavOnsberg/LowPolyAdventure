using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    public float attackDist = 3;
    Transform player;
    NavMeshAgent nav;
    public bool canMove = true;
    Animator anim;
    Vector3 frozenPos;
    Vector3 frozenRot;

	void Start ()
    {
	    nav = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
	    anim = GetComponent<Animator>();
    }
	
	void Update () 
    {
        if (canMove)
        {
            nav.SetDestination(player.position);

            if (Vector3.Distance(transform.position, player.position) < attackDist)
                print("attacking");
        }
        else
        {
            transform.position = frozenPos;
            transform.eulerAngles = frozenRot;
        }
    }

    public IEnumerator Frozen()
    {
        frozenPos = transform.position;
        frozenRot = transform.eulerAngles;
        anim.SetBool("CanMove", false);
        canMove = false;
        yield return new WaitForSeconds(3);
        canMove = true;
        anim.SetBool("CanMove", true);
    }
}
