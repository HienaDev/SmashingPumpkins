using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinMan : MonoBehaviour
{

    [SerializeField] private int moveSpeed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
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
