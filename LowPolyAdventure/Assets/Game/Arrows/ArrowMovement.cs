using UnityEngine;
using System.Collections;

public class ArrowMovement : MonoBehaviour {

	// Use this for initialization

    float speed;


	void Start () {
        speed = GameObject.Find("GameController").GetComponent<GameController>().arrowSpeed;
        rigidbody.AddForce(transform.forward * speed, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
