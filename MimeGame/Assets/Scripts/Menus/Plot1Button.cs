using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plot1Button : MonoBehaviour
{
    public void NextScene()// hit next scene button
    {
        SceneManager.LoadScene("Plot2");// loads plot 2 scene
    }
}
