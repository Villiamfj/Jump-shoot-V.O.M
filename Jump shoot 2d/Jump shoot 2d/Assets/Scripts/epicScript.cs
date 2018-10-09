using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class epicScript : MonoBehaviour {
    public GameObject Epic;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.L))
        {
            Epic.SetActive(true);
        }
        else
        {
            Epic.SetActive(false);
        }
	}
}
