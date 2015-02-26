using UnityEngine;
using System.Collections;

public class Staff : MonoBehaviour {

    public GameObject spell;
    public Transform spellSpawn;
    public float force;

	void Start () 
    {
	
	}

	void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(spell, spellSpawn.position, spellSpawn.rotation) as GameObject;
            go.rigidbody.AddForce(spellSpawn.transform.forward*force);
        }
	}
}
