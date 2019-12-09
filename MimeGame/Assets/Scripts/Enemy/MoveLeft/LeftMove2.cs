using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMove2 : MonoBehaviour
{
    public GameObject enemyPrefab;
    float speed = -5f;// sets speed as a variable

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);// calls for the component attached to the object


        if (transform.position.x < -2f)// if the objects x is less than -2
        {
            transform.position = new Vector2(5.6f, -5.28f);// set the objects coordinates to this
        }
    }
}
