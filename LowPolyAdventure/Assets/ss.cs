using UnityEngine;
using System.Collections;

public class ss : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.renderer.material.color = new Color(gameObject.renderer.material.color.r, gameObject.renderer.material.color.g, gameObject.renderer.material.color.b, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
