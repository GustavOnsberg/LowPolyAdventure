using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    public float curHealth;

    public void AdjustHealth(float adj)
    {
        curHealth += adj;

        if (curHealth <= 0)
            Destroy(gameObject);
    }

}
