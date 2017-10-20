using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    public float shootRate = 0.5f;

    private float shootTimer = 0f;

    // Use this for initialization
    void Start()
    {

    }

    void Shoot()
    {
        GameObject clone = Instantiate(bulletPrefab, transform.position, transform.rotation);

        Rigidbody2D rigid = clone.GetComponent<Rigidbody2D>();
        rigid.AddForce(transform.up * bulletSpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        // Count Up Shoot Timer
        shootTimer += Time.deltaTime;
        // Check if shootTimer is greater than shootRate
        if(shootTimer > shootRate)
        {
            // If space is pressed
            if (Input.GetKey(KeyCode.Space))
            {
                // Shoot the projectile!! GAT
                Shoot();
                //Rate ShootTimer
               
                shootTimer = 0f;
            }
        }
    }
}
