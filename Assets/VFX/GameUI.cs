using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    private Sprite _lifeFull;
    [SerializeField]
    private Sprite _lifeEmpty;
    [SerializeField]
    private Image[] _life;


    public void ChangeHealth(int health)
    {
        foreach (Image i in _life)
        {
            i.sprite = _lifeEmpty;
        }

        for (int i = 0; i < health; i++)
        {
            _life[i].sprite = _lifeFull;
        }

        if (health == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
