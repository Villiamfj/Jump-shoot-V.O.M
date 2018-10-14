using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {
    private Vector3 mousePosition;
    public Rigidbody2D rb;
    public GameObject player;
    public float Bulletspeed;
    public float lifetime;


    public float bulletVelocity;
    // Use this for initialization
    void Start () {

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioManager.audioManager.playSound(1);
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject, 0.1f);
            Win.reference.EnemyKilled += 1;
        }
        Destroy(gameObject, 0.1f);
    }
}
