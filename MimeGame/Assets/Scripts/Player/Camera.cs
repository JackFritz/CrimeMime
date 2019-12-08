using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;   // public var that refers to the game object we want to follow player/ball
    private Vector3 offset;   // private var that determines the camera distance from the player/ball
    internal static object main;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    internal static Vector2 ScreenToWorldPoint(Vector3 vector3)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + 0.2f * offset;
    }
}
