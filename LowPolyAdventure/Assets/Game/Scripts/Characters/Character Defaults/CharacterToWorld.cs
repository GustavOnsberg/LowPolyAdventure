using UnityEngine;
using System.Collections;

public class CharacterToWorld : MonoBehaviour {



    GameObject cameraController;
    CameraController cameraControllerScript;


	void Start () {
        cameraController = GameObject.Find("CameraController");
        cameraControllerScript = cameraController.GetComponent<CameraController>();
        cameraControllerScript.player = transform;
    }
}
