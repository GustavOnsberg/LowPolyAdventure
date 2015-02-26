using UnityEngine;
using System.Collections;

public class ArrowSpawner : MonoBehaviour {


    public GameObject arrow;
    public GameObject arrowFire;
    public GameObject arrowIce;
    public GameObject arrowMagic;


    public float shootDelay;
    float countDown;


	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && countDown <= 0)
        {
            Instantiate(arrow, transform.position, transform.rotation);
        }
	}
}
