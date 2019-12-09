using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void RollCredits()// hit roll credits button
    {
        SceneManager.LoadScene("Credits");// loads credit scene
    }
}