using UnityEngine;
using System.Collections;

public class CharacterToWorld : MonoBehaviour {



    GameObject cameraController;
    CameraController cameraControllerScript;


	void Start () {
        cameraController = GameObject.Find("CameraController");
        cameraControllerScript = cameraController.GetComponent<CameraController>();
	}
	
	// Update is called once per frame
	void Update () {
        cameraControllerScript.goTo = transform.position;
	}
}
