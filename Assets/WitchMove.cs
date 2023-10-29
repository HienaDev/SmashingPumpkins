using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchMove : MonoBehaviour
{

    [SerializeField] private float speed;
    private float tempSpeed;

    private Vector2 velocity;

    private Rigidbody2D rb;

    private bool isFacingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tempSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        velocity = Vector2.zero;


        if (transform.position.x < -195)
        {
            tempSpeed = speed;
        }

        if (transform.position.x > 195)
        {
            tempSpeed = -speed;
        }

        velocity = new Vector2(tempSpeed, 0f);

        rb.velocity = velocity;

        Flip();
    }

    private void Flip()
    {
        if (isFacingRight && rb.velocity.x < 0f || !isFacingRight && rb.velocity.x > 0f)
        {
            isFacingRight = !isFacingRight;

            transform.Rotate(0f, 180f, 0f);
        }
    }
}
