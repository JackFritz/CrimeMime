using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plot3Button : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Plot4");
    }
}
