using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plot2Button : MonoBehaviour
{
    public void NextScene()// next scene button hit
    {
        SceneManager.LoadScene("Plot3");// loads plot 3 scene
    }
}
