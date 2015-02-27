using UnityEngine;
using System.Collections;

public class DeadSlime : MonoBehaviour {

	void Start () {
	
	}
	
	void FixedUpdate () {
        transform.position = new Vector3(transform.position.x, transform.position.y-0.001f, transform.position.z);
        if (transform.position.y < -1)
        {
            Destroy(gameObject);
        }
	}
}
