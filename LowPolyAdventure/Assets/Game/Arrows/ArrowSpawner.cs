using UnityEngine;
using System.Collections;

public class ArrowSpawner : MonoBehaviour {


    public GameObject arrow;
    public GameObject arrowFire;
    public GameObject arrowIce;
    public GameObject arrowMagic;


    public float shootDelay;
    float countDown;
    float speed;

	// Use this for initialization
	void Start () {
        speed = GameObject.Find("GameController").GetComponent<GameController>().arrowSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(arrow, transform.position, transform.rotation) as GameObject;
            go.rigidbody.AddForce(transform.forward * speed, ForceMode.Impulse);
        }
	}
}
