using UnityEngine;
using System.Collections;

public class ArrowMovement : MonoBehaviour {

	// Use this for initialization

    float speed;
    bool firstFrame;

	void Start () {
        speed = GameObject.Find("GameController").GetComponent<GameController>().arrowSpeed;
	}
	
	
    void FixedUpdate() 
	{
        rigidbody.AddForce(transform.up * speed);
	}

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
        Destroy(gameObject);
    }
}
