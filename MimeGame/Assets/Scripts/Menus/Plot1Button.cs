using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plot1Button : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Plot2");
    }
}
