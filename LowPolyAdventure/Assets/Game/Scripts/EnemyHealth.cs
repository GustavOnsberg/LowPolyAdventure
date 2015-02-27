using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    public float curHealth;
    public GameObject dead;

    public void AdjustHealth(float adj)
    {
        curHealth += adj;

        if (curHealth <= 0)
        {
            if (dead != null)
            {
                Instantiate(dead, new Vector3(transform.position.x, 0, transform.position.z), transform.rotation);   
            }
            Destroy(gameObject);
        }
    }

}
