using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCount : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Win.reference.EnemyCount += 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
