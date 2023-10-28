using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableJump : MonoBehaviour
{
    [SerializeField] private LayerMask groundMask;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int x = 1 << collision.gameObject.layer;



        // Trigger Clown Falling
        if (x == groundMask.value)
        {
            PlayerMovement temp = gameObject.GetComponentInParent<PlayerMovement>();
            temp.EnableJump();
        }
    }
}
