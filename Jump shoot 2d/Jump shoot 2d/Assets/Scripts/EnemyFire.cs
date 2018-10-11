using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour {

    public float fireRate = 0;
    public GameObject ShotBullet;
    public GameObject Player;
    public float range;
    public LayerMask WhatToHit;

    float nextfire = 0;
    Transform firePoint;


    // Use this for initialization
    void Awake()
    {
        firePoint = transform;
        if (firePoint == null)
        {
            Debug.LogError("wut no firepoint?");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 PlayerPosition = new Vector2(Player.transform.position.x, Player.transform.position.y);//Camera.main.WorldToViewportPoint(Player.transform.position).x, Camera.main.WorldToViewportPoint(Player.transform.position).y);
        Vector2 FirePosition = new Vector2(transform.position.x,transform.position.y);
        RaycastHit2D hit = Physics2D.Raycast(FirePosition, PlayerPosition - FirePosition, 100, WhatToHit);
        Debug.DrawLine(FirePosition, (PlayerPosition - FirePosition) * 100, Color.cyan);
        if (hit.collider != null)
        {
            if (hit.collider.tag == "Player" && Time.time > nextfire)
            {
                nextfire = Time.time + fireRate;

                Vector3 worldMousePos = Player.transform.position;//Camera.main.WorldToViewportPoint(Player.transform.position);

                Vector2 direction = (Vector2)((worldMousePos - transform.position));
                direction.Normalize();

                // Creates the bullet locally
                GameObject bullet = (GameObject)Instantiate(
                                        ShotBullet,
                                        transform.position + (Vector3)(direction * 0.5f),
                                        Quaternion.identity);
            }
        }
    }
}
