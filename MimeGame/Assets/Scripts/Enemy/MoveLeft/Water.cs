using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
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
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0); //calls the component from the object the script is attached too


        if (transform.position.x < -2f)// if the object is less than -2 x
        {
            transform.position = new Vector2(5.65f, -2.44f);// set the objects coordinates to what is given
        }
       
    }
}
