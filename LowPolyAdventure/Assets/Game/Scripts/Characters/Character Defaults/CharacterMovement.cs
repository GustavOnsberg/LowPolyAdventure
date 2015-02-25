using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    public float speed = 5;

	void Start ()
    {
	    
	}
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Walk(speed * 2);
        }
        else
        {
            Walk(speed);
        }
	}

    void Walk(float speed)
    {
        rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed,
                                      0, Input.GetAxis("Vertical") * speed);
    }
}
