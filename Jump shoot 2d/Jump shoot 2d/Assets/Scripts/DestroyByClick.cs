using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByClick : MonoBehaviour {

    public int Button;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(Button))
        {
            Destroy(gameObject, 0.2F);
        }

    }

}
