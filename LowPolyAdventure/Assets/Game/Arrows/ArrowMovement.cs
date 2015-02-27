using UnityEngine;
using System.Collections;

public class ArrowMovement : MonoBehaviour {

	// Use this for initialization
    float speed;
    bool firstFrame;
    public float damage;
    Vector3 freezePos;

	void Start () {
        speed = GameObject.Find("GameController").GetComponent<GameController>().arrowSpeed;
        Physics.IgnoreLayerCollision(11, 11, true);
	}
	
	
    void FixedUpdate() 
	{
        if (speed > 0)
        {
            rigidbody.AddForce(transform.forward * speed, ForceMode.Force);
            rigidbody.AddForce(-transform.up * speed/2, ForceMode.Force);
        }
        else
        {
            transform.position = freezePos;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.CompareTag("Enemy"))
        {
            EnemyHealth eh = col.transform.GetComponent<EnemyHealth>();
            eh.AdjustHealth(damage);
            if (transform.name == "FreezingArrow(Clone)")
            {
                EnemyAI ai = col.transform.GetComponent<EnemyAI>();
                ai.StartCoroutine("Frozen");
            }
        }
        transform.parent = col.transform;
        transform.rigidbody.velocity = Vector3.zero;
        rigidbody.freezeRotation = true;
        freezePos = transform.position;
        Destroy(transform.collider);
        Destroy(this);
    }
}
