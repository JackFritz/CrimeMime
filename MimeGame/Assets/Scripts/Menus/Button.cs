using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void StartGame()// hit start game button
    {
        SceneManager.LoadScene("Level1");// loads level 1 scene
    }
}