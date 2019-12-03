using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinButton : MonoBehaviour
{
    public void LeaveGame()
    {
        SceneManager.LoadScene("Title");
    }
}
