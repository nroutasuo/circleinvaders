﻿using UnityEngine;
using System.Collections;

public class ShootBullets : MonoBehaviour {

    public GameObject Bullet;

	void Start ()
    {
	
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(Bullet, transform.position, Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody2D>().AddForce(transform.up * 10, ForceMode2D.Impulse);
    }
}
