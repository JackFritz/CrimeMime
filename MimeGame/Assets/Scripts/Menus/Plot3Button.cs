using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plot3Button : MonoBehaviour
{
    public void NextScene()// hit next scene button
    {
        SceneManager.LoadScene("Plot4");// load plot 4 scene
    }
}
