using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLogic : MonoBehaviour
{
    [SerializeField] private string gameplaySceneName;
    public void Retry()
    {
        SceneManager.LoadScene(gameplaySceneName, LoadSceneMode.Single);
    }
    public void Quit()
    {
        Application.Quit();
    }
}