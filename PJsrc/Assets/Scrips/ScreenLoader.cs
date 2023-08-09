using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    public void exitGameNow()
    {
        Application.Quit();
    }

    public void resetGameNow()
    {
        SceneManager.LoadScene(0);
    }
}
