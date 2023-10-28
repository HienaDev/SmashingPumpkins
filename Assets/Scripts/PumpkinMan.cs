using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinMan : MonoBehaviour
{

    private Rigidbody2D rb;
    private int moveSpeed;

    // Start is called before the first frame update
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        moveSpeed = 5;
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }

    public void ChangeDirection()
    {
        moveSpeed = -moveSpeed;
    }
}
