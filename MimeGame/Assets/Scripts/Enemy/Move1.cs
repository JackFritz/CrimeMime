using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    float speed = -5f;// set speed 5 to the left

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);// have character move up and down

      
    }
    private void OnCollisionEnter2D(Collision2D collision)// on collision
    {
        if(collision.gameObject.tag == "wall")// on collision with gameobject wall
        {
            speed = speed * -1;// have speed go to the other direction
        }
    }
}
