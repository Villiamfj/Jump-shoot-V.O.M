using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBulletMove : MonoBehaviour {
    private Vector3 mousePosition;
    public Rigidbody2D rb;
    public float Bulletspeed;
    public float lifetime;
    public GameObject target;
    public float bulletVelocity;
    // Use this for initialization
    void Start()
    {
        target = GameObject.Find("Player");
        Vector2 direction = (Vector2)((target.transform.position - transform.position));
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
        AudioManager.audioManager.playSound(1);
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject, 0.1f);
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
        Destroy(gameObject, 0.1f);

    }
}
