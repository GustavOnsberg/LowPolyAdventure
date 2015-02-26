using UnityEngine;
using System.Collections;

public class ArrowMovement : MonoBehaviour {

	// Use this for initialization
    float speed;
    bool firstFrame;
    public float damage;

	void Start () {
        speed = GameObject.Find("GameController").GetComponent<GameController>().arrowSpeed;
	}
	
	
    void FixedUpdate() 
	{
        rigidbody.AddForce(transform.forward * speed, ForceMode.Force);
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.CompareTag("Enemy"))
        {
            EnemyHealth eh = col.transform.GetComponent<EnemyHealth>();
            eh.AdjustHealth(damage);
        }
        Destroy(gameObject);
    }
}
