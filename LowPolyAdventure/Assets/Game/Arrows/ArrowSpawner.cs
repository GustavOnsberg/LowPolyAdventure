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


	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (countDown <= 0)
    	{
            readyToShoot = true;
    	}
        else
        {
            countDown -= Time.deltaTime;
        }


        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(arrow, transform.position, transform.rotation) as GameObject;
            go.rigidbody.AddForce(transform.forward * 20, ForceMode.Impulse);
        }
	}
}
