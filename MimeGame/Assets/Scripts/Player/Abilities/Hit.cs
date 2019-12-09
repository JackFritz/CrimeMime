using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public Animator Swing;
    public AudioSource Whip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))// hit the L button
        {
            Whip.Play();// play the whip audio
            Swing.SetTrigger("IsHitting");// activate the whip animator
            
        }
    }
}
