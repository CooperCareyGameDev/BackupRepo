using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public float speed;
    public float bulletLifeTime = 1.5f;
    public AudioClip shootSound;
    // Update is called once per frame
    void Update()
    {

        if (Time.timeScale == 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                GameObject bulletSpawn = Instantiate(bullet, transform.position, Quaternion.identity);
                Vector3 mousePosition = Input.mousePosition;
                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                Vector3 shootDirection = mousePosition - transform.position;
                shootDirection.Normalize();
                bulletSpawn.GetComponent<Rigidbody2D>().velocity = shootDirection * speed;
                Destroy(bulletSpawn, bulletLifeTime);
                Camera.main.GetComponent<AudioSource>().PlayOneShot(shootSound);
            }
        }
    }
}
