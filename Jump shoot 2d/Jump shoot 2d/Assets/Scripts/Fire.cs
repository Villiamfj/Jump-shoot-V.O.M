using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    public float fireRate = 0;
    public LayerMask noHit;
    public GameObject ShotBullet;


    float nextfire = 0;
    Transform firePoint;


	// Use this for initialization
	void Awake () {
        firePoint = transform;
        if (firePoint == null)
        {
            Debug.LogError("wut no firepoint?");
        }
	}
	
	// Update is called once per frame
	void Update () {
        /*
        //shoot
        if (Input.GetMouseButton(0) && Time.time > nextfire)
        {
            nextfire = Time.time + fireRate;
            Instantiate(ShotBullet, transform.position, Quaternion.identity);
        }
        */
        if (Input.GetMouseButton(0) && Time.time > nextfire)
        {
            nextfire = Time.time + fireRate;
            Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 direction = (Vector2)((worldMousePos - transform.position));
            direction.Normalize();

            // Creates the bullet locally
            GameObject bullet = (GameObject)Instantiate(
                                    ShotBullet,
                                    transform.position + (Vector3)(direction * 0.5f),
                                    Quaternion.identity);

        }

    }
}
