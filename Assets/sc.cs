﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    public float speed1 = 1f;
    private Rigidbody2D rig1;
    // Start is called before the first frame update
    void Start()
    {
        rig1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){

            rig1.velocity = Vector2.up * speed1;
            
        }
        
    }
}