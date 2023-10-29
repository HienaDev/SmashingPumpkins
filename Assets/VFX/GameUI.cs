using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField]
    private Sprite _lifeFull;
    [SerializeField]
    private Sprite _lifeEmpty;
    [SerializeField]
    private Image _life1;
    [SerializeField]
    private Image _life2;
    [SerializeField]
    private Image _life3;
    [SerializeField]
    private Image[] _life;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
    }
}
