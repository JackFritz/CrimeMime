﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plot2Button : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Plot3");
    }
}