﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_script : MonoBehaviour {

    static float speed;
	// Use this for initialization
	void Start ()
    {
        speed = 5f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime,
                            0f,
                            speed * Input.GetAxis("Vertical") * Time.deltaTime);
	}
}
