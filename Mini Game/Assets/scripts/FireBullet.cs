using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        projectilePrefab.transform.position = gameObject.transform.position;
        projectilePrefab.transform.forward = gameObject.transform.forward;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // launch a projectile from the player
            Shoot();
        }
    }
    void Shoot()
    {
        var bulletInstance = Instantiate(projectilePrefab);
    }
}
