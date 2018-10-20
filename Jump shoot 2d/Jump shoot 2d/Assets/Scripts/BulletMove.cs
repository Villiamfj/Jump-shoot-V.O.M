using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {
    private Vector3 mousePosition;
    public Rigidbody2D rb;
    public float Bulletspeed;
    public float lifetime;


    public float bulletVelocity;
    // Use this for initialization
    void Start () {
        //Får musens kordinater
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        //Finder en retning fra objectet til musen
        Vector2 direction = (Vector2)((worldMousePos - transform.position));
        direction.Normalize();

        // Adds velocity to the bullet
        GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity;

        //objectet ødelægger sig selv efter noget tid
        Destroy(gameObject, lifetime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //spiller lyd
        AudioManager.audioManager.playSound(1);
        //Tjekker om det andet object er en fjende
        if (collision.gameObject.tag == "Enemy")
        {
            //Stopper collision
            collision.gameObject.GetComponent<Collider2D>().enabled = false;
            //Ødelægger objectet efter et antal tid
            Destroy(collision.gameObject, 0.1f);
            //Addere 1 til antallet af dræbte fjender
            Win.reference.EnemyKilled += 1;


        }
        Destroy(gameObject, 0.1f);
    }
}
