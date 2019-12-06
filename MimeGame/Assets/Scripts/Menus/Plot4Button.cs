using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plot4Button : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Plot5");
    }
}
