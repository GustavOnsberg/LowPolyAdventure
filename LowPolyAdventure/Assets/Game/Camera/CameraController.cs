using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {



    public float delay;



    [HideInInspector]
    public Vector3 goTo;




	void Start () {
	    
	}
	
	


	void Update () {
        transform.position = Vector3.Lerp(transform.position, goTo, delay * Time.deltaTime);
	}
}
