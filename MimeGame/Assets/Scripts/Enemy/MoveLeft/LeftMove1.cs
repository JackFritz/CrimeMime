﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMove1 : MonoBehaviour
{
    public GameObject enemyPrefab;
    float speed = -5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);


        if (transform.position.x < -2f)
        {
            transform.position = new Vector2(8.9f, -3.92f);
        }
    }
}