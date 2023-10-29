using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinBombsExplode : MonoBehaviour
{
    [SerializeField] private GameObject particleDeath;

    private float justHit;
    private bool bopped = false;
    [SerializeField] private float timeAlive;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - justHit > timeAlive && bopped)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {





            GameObject temp = Instantiate(particleDeath, gameObject.transform);
            temp.transform.eulerAngles = new Vector3(0, 0, 180);
            temp.transform.position = gameObject.transform.position;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            justHit = Time.time;
            bopped = true;

    }
}
