using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAnimationHandler : MonoBehaviour
{
    private void Quit()
    {
        Application.Quit();
    }

    private void Play()
    {
        SceneManager.LoadScene(2);
    }
}
