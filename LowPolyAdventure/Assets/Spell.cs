using UnityEngine;
using System.Collections;

public class Spell : MonoBehaviour {

    public float force = 10;

	void Start () 
    {
	    
	}
	
	void FixedUpdate () 
    {
        rigidbody.AddForce(transform.forward * force);
	}

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
        Destroy(gameObject);
    }
}
