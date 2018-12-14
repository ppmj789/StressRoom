﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    /*
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    */
    public float speed = 10f;
    Rigidbody rigdbody;
    Vector3 movement;

    void Awake()
    {
        rigdbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Run(h, v);
    }

    void Run(float h, float v)
    {
        movement.Set(h, 0, v);
        movement = movement.normalized * speed * Time.deltaTime;

        rigdbody.MovePosition(transform.position + movement);
    }
}
