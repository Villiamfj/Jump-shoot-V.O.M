using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    private Vector3 mousePosition;
    public float moveSpeed;
    public Rigidbody2D rb2D;
    public float timeStamp;
    public float coolDownPeriodInSeconds;
    Camera cam;
    // Use this for initialization
    void Start()
    {
        cam = Camera.main;
        timeStamp = Time.time + coolDownPeriodInSeconds;
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(1) & timeStamp <= Time.time)
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            rb2D.AddForce(mousePosition*moveSpeed);
            //transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
            timeStamp = Time.time + coolDownPeriodInSeconds;
        }

    }
}
