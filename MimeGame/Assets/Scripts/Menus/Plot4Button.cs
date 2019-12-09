using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plot4Button : MonoBehaviour
{
    public void NextScene()// hit next scene button
    {
        SceneManager.LoadScene("Plot5");// loads plot 5 scene
    }
}
