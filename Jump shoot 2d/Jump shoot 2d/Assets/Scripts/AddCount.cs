using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCount : MonoBehaviour {
    int RL;
    public float speed = 1;
    Rigidbody2D rb2D;
    float H;
    // Use this for initialization
    void Start () {
        //Optælling af fjender
        Win.reference.EnemyCount += 1;
        RL = Random.Range(0, 2);
        rb2D = GetComponent<Rigidbody2D>();
        H = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //tegner 2 linjer under objectet en i hver side, og kigge om den rører noget
        Vector2 lineCastPosL = new Vector2(transform.position.x - 0.5F,transform.position.y -0.5F);
        Vector2 lineCastPosR = new Vector2(transform.position.x + 0.5F,transform.position.y - 0.5F);
        Debug.DrawLine(lineCastPosL, lineCastPosL + Vector2.down);
        Debug.DrawLine(lineCastPosR, lineCastPosR + Vector2.down);
        bool isGroundedL = Physics2D.Linecast(lineCastPosL, lineCastPosL + Vector2.down);
        bool isGroundedR = Physics2D.Linecast(lineCastPosR, lineCastPosR + Vector2.down);
        
        // ændrer retning iforhold til om linjerne rører noget
        if (!isGroundedL)
        {
            RL = 0;
        }
        if (!isGroundedR)
        {
            RL = 1;
        }
        if (RL == 1)
        {
            H = -1;
        }
        if (RL == 0)
        {
            H = 1;
        }

        //Objectet flytter sig
        Vector2 move =new Vector2 (H, 0);
        rb2D.velocity = move*speed;
    }

    //skifter retning ved sammenstød
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (RL == 1)
        {
            RL = 0;
        }
        else if (RL == 0)
        {
            RL = 1;
        }
    }
}
