using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public Transform firePoint; // create fire point for prefab
    public GameObject hitPrefab;  // place to drop prefab
    //public AudioSource hit; // place for drop audio  The audio messes with the death sound
    private float timeBetweenShots = 0.8f;  // time between each shot
    private float delaytime; // call delay time
    

    // Start is called before the first frame update
    void Start()
    {
        //hit = GetComponent<AudioSource>(); // get the audio source 
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= delaytime && (Input.GetKeyDown(KeyCode.L))) // Use L to hit
        {
            Boom(); // activate the shoot function
            delaytime = Time.time + timeBetweenShots; // delay time = timebtwshots
        }
        

    }
    void Boom() // shoot function
    {
        Instantiate(hitPrefab, firePoint.position, firePoint.rotation); 

        //hit.Play(); // play the audio
    }
}
