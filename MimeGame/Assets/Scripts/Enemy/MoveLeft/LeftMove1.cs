using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMove1 : MonoBehaviour
{
    public GameObject enemyPrefab;
    float speed = -5f;// sets speed as a variable to be called on.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);//calls for component on attached object


        if (transform.position.x < -2f)//if object is less than -2
        {
            transform.position = new Vector2(8.9f, -3.92f);// move object to these coordinates
        }
    }
}
