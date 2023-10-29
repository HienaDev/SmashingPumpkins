using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    [SerializeField]
    private int _maxHealth = 3;
    [SerializeField]
    private int _currentHealth = 0;
    [SerializeField]
    private LayerMask _batMask;
    [SerializeField]
    private LayerMask _jackMask;
    [SerializeField]
    private bool _vulnerable = true;
    [SerializeField]
    private GameUI _gameUI;

    // Start is called before the first frame update
    void Start()
    {
        _currentHealth = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int x = 1 << collision.gameObject.layer;

        if (x == _jackMask.value && _vulnerable)
        {
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        _currentHealth--;
        StartCoroutine(InvencibilityWindowCoroutine());
    }

    IEnumerator InvencibilityWindowCoroutine()
    {
        _vulnerable = false;
        yield return new WaitForSeconds(1.5f);
        _vulnerable = true;
    }
}
