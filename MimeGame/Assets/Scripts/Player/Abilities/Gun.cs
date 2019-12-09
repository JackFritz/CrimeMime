using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource JohnWick;
    public Animator bang;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))//on pressing down the button
        {
            Shoot();// shoot function called
            JohnWick.Play();// john wick audio played
           bang.SetTrigger("IsShooting");// bang animation palys
            
        }

    }

   

    void Shoot()
    {
        //Shooting Mechanics, Press the Space Bar to Shoot
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
