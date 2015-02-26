using UnityEngine;
using System.Collections;

public class ArrowMovement : MonoBehaviour {

	// Use this for initialization

    float speed;
    bool firstFrame;

	void Start () {
        speed = GameObject.Find("GameController").GetComponent<GameController>().arrowSpeed;
        //rigidbody.AddForce(transform.forward * speed, ForceMode.Impulse);
        rigidbody.velocity = Vector3.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
        if (firstFrame)
        {
            //rigidbody.AddForce(transform.forward * speed, ForceMode.Impulse);
            firstFrame = false;
        }
	}
}
