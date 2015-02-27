using UnityEngine;
using System.Collections;

public class ArrowSpawner : MonoBehaviour {

    public GameObject arrow;
    public GameObject arrowFire;
    public GameObject arrowIce;
    public GameObject arrowMagic;

    public float shootDelay;
    float countDown;

    bool readyToShoot;
    bool shootWhenReady;

	void Start ()
    {
	    
	}

	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(arrow, transform.position, transform.rotation) as GameObject;
            go.rigidbody.AddForce(transform.forward * 20, ForceMode.Impulse);
        }
	}
}
