using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float delay;

    [HideInInspector]
    public Transform player;

	void Start ()
    {
	    
	}

	void Update ()
    {
        transform.position = Vector3.Lerp(transform.position, player.position, delay * Time.deltaTime);
	}
}
