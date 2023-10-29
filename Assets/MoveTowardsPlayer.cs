using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{

    private GameObject player;
    private Rigidbody2D rb;

    [SerializeField] private float speed;
    [SerializeField] private float distance;

    private Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        velocity = new Vector2(0f, rb.velocity.y);

        if (gameObject.transform.position.x < player.transform.position.x - distance)
        {
            velocity.x = speed;
        }
        else if (gameObject.transform.position.x > player.transform.position.x + distance)
        {
            velocity.x = -speed;
        }
        else
            velocity.x = 0f;

        rb.velocity = velocity;
    }

    public void Death()
    {
        speed = 0;
    }

    public void DestroyJack()
    {
        Destroy(gameObject);
    }
}
