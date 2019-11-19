using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
        
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }

    // Fires prefab from empty gameobject
    void shoot()
    {
        /*
        ForeMode2D.Impulse =
        Add an instant force impulse to the rigidbody2D, using its mass.
        Apply the impulse force instantly.
        This mode depends on the mass of rigidbody so more force must be applied to move higher-mass objects the same amount as lower-mass objects.
        This mode is useful for applying forces that happen instantly, such as forces from explosions or collisions.
         */
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

}
