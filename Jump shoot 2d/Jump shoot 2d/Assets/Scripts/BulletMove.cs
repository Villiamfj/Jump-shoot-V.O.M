﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {
    private Vector3 mousePosition;
    public Rigidbody2D rb;
    public GameObject player;
    public float Bulletspeed;
    public float lifetime;
    public GameObject wall;

    public float bulletVelocity;
    // Use this for initialization
    void Start () {

        /*
        rb = GetComponent<Rigidbody2D>();
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 vej = mousePosition - transform.position;
        rb.velocity = vej*Bulletspeed;
        */
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = (Vector2)((worldMousePos - transform.position));
        direction.Normalize();
        // Adds velocity to the bullet
        GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity;


        Destroy(gameObject, lifetime);
    }
	
	// Update is called once per frame
	void Update () {

	}
}