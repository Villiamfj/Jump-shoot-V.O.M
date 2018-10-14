using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassDestroy : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioManager.audioManager.playSound(0);
            //audiosource.clip = GlassBreak;
            Destroy(gameObject);
        }
    }
}
