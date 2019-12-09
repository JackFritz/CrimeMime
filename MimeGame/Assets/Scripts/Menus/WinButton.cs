using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinButton : MonoBehaviour
{
    public void LeaveGame()// hit leave game button
    {
        SceneManager.LoadScene("Title");// loads title screen
    }
}
