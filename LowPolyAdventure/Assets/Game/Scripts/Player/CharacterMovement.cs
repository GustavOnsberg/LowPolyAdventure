using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    public float speed = 5;

    Ray mouseRay;
    RaycastHit mouseHit;
    Animator anim;

	void Start ()
    {
	    anim = GetComponent<Animator>();    
	}
	
	void Update ()
    {
        rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed,
        rigidbody.velocity.y, Input.GetAxis("Vertical") * speed);

        anim.SetFloat("Rigid X", rigidbody.velocity.x);
        anim.SetFloat("Rigid Z", rigidbody.velocity.z);

        SetPlayerDirection();
	}




    void SetPlayerDirection() {
        mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(mouseRay,out mouseHit, 100))
        {
            transform.rotation = Quaternion.LookRotation((new Vector3(mouseHit.point.x, transform.position.y, mouseHit.point.z) - transform.position).normalized);
            Debug.DrawLine(mouseRay.origin, mouseHit.point + new Vector3(0, 1, 0), Color.blue);
            Debug.DrawLine(transform.position + new Vector3(0, 1, 0), mouseHit.point + new Vector3(0, 1, 0), Color.red);
        }
    }
}
