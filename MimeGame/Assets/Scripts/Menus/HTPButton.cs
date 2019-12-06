using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HTPButton : MonoBehaviour
{
    public void Instructions()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}