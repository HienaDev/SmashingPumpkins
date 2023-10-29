using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Animator _menuAnimator;
    [SerializeField]
    private AudioClip[] _buttonsAudio;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    public void StartGame()
    {
        _audioSource.PlayOneShot(_buttonsAudio[0]);
        _menuAnimator.SetTrigger("Start");
    }

    public void QuitGame()
    {
        _audioSource.PlayOneShot(_buttonsAudio[1]);
        _menuAnimator.SetTrigger("Quit");
    }

    public void About()
    {
        SceneManager.LoadScene(1);
    }

}
