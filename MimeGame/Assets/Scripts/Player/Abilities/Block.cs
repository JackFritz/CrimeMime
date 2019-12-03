using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Animator Wall;
    public AudioSource Rubber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            Rubber.Play();
            Wall.SetTrigger("IsBlocking");
            //BoxCollider2D.GameObject = false;
        }
    }
}
