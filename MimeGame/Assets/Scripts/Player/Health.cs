using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private float HP = 3f; // initialize HP 
    public AudioSource Ouch;// plays audio when hit
    public GameObject HP1;// HP1 visual
    public GameObject HP2;// HP2 visual
    public GameObject HP3;// HP3 visual

    // Start is called before the first frame update
    void Start()
    {
        Ouch = GetComponent<AudioSource>();// plays auido for ouch
        HP1.gameObject.SetActive(true);// shows Hp1
        HP2.gameObject.SetActive(true);// shows Hp2
        HP3.gameObject.SetActive(true);// shows Hp3
    }

    // Update is called once per frame
    void Update()
    {
        if ( HP == 2)// if damaged once
        {
            HP3.gameObject.SetActive(false);// delete Hp3
        }
        if (HP == 1)// if damaged twice
        {
            HP2.gameObject.SetActive(false);// delete Hp 2
        }

        if (HP <= 0)// if damaged thrice
        {
            SceneManager.LoadScene("Lose");// loads lose scene
        }
        Debug.Log("Player HP: " + HP);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "enemy")// coliding with enemy causes
        {
            HP -= 1f;// -1 HP 
            Ouch.Play();// and ouch to play
        }
        if (collision.gameObject.tag == "win")// if colides with the last flag
        {
            SceneManager.LoadScene("Win");// load win scene
        }
    }
}
