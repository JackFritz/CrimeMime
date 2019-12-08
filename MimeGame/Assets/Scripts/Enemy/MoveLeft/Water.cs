using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
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
            transform.position = new Vector2(5.65f, -2.44f);
        }
       
    }
}
