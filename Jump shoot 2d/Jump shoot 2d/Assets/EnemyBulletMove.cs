using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMove : MonoBehaviour {
    private Vector3 mousePosition;
    public Rigidbody2D rb;
    public GameObject player;
    public float Bulletspeed;
    public float lifetime;


    public float bulletVelocity;
    // Use this for initialization
    void Start()
    {

        /*
        rb = GetComponent<Rigidbody2D>();
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 vej = mousePosition - transform.position;
        rb.velocity = vej*Bulletspeed;
        */

        Vector2 direction = (Vector2)((player.transform.position - transform.position));
        direction.Normalize();
        // Adds velocity to the bullet
        GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity;


        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject, 0.1f);
        }
        Destroy(gameObject, 0.1f);
    }
}
