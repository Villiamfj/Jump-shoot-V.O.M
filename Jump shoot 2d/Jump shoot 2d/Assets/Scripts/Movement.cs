﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    private Vector3 mousePosition;
    public float moveSpeed;
    public Rigidbody2D rb2D;

    bool Midjump;
    // Use this for initialization
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        Midjump = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(1) & Midjump == false)
        {
            Midjump = true;
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            rb2D.AddForce(mousePosition*moveSpeed);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Midjump = false;
    }
}
