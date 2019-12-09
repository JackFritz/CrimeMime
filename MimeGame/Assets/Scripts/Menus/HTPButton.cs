using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HTPButton : MonoBehaviour
{
    public void Instructions()// hit button instructions
    {
        SceneManager.LoadScene("HowToPlay");// how to play scene loads
    }
}