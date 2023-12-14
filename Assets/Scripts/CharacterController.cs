using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Transform bulletDot;
    public GameObject foodProjectile;
    public float projectileSpeed = 10f;


    public int hungerValue = 25;

    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject projectile = Instantiate(foodProjectile, bulletDot.position, bulletDot.rotation);

        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        rb.velocity = bulletDot.right * projectileSpeed;

    }
}
