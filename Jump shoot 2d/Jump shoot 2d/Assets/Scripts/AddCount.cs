using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCount : MonoBehaviour {
    int RL;
    public float speed = 1;
    Rigidbody2D rb2D;


	// Use this for initialization
	void Start () {
        Win.reference.EnemyCount += 1;
        RL = Random.Range(0, 2);
        rb2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float H = 0;
        if (RL == 1)
        {
            H = -1;
        }
        if (RL == 0)
        {
            H = 1;
        }
        Vector2 move =new Vector2 (H*speed, 0);
        rb2D.velocity = move;
    }
}
