using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plot5Button : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Warning");
    }
}
