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
            /*Instantiate(arrow, transform.position, Quaternion.identity);*/

            shootWhenReady = true;
        }

        if (readyToShoot && shootWhenReady)
        {
            Instantiate(arrow, transform.position, Quaternion.identity);
            countDown = shootDelay;
            readyToShoot = false;
            shootWhenReady = false;
        }
	}
}
