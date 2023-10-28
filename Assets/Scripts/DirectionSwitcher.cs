using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionSwitcher : MonoBehaviour
{
    private GameObject enemy;
    private PumpkinMan pumpkinMan;

    // Start is called before the first frame update
    private void Start()
    {
        enemy = transform.parent.Find("Enemy").gameObject;
        pumpkinMan = enemy.GetComponent<PumpkinMan>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == enemy)
        {
            pumpkinMan.ChangeDirection();
        }
    }
}
