using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {
    private Vector3 mousePosition;
    public Rigidbody2D rb;
    public GameObject player;
    public float Bulletspeed;
    public float lifetime;
    public GameObject wall;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 vej = mousePosition - transform.position;
        rb.velocity = vej*Bulletspeed;
        Destroy(gameObject, lifetime);
    }
	
	// Update is called once per frame
	void Update () {

	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == wall)
        {
            
        }
    }
}
