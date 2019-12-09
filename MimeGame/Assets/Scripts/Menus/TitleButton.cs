using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
    public void StartGame()// hit start game button
    {
        SceneManager.LoadScene("Plot1");// loads plot 1 scene
    }
}