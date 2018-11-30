using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mosterAttack : MonoBehaviour {
    public GameObject Spike;
    public bool canShoot = true;
    public float shootDelay;
    float shootTimer = 0;

    void LateUpdate() 
    {
        if (shootTimer > shootDelay) 
        {
            Instantiate(Spike, transform.position, Quaternion.identity);
            shootTimer = 0;
        }
        shootTimer += Time.deltaTime;
    }

}
