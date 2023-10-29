using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectHomerun : MonoBehaviour
{

    [SerializeField] private LayerMask batMask;

    [SerializeField] private GameObject pumpkin;

    private Animator jackAnimator;

    private GameObject pumpkinManager;

    [SerializeField] private float speedY;
    [SerializeField] private float speedX;

    private GameObject player;

    private bool left;

    // Start is called before the first frame update
    void Start()
    {
        jackAnimator = GetComponentInParent<Animator>();
        pumpkinManager = FindAnyObjectByType<PumpkinManager>().gameObject;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x < player.transform.position.x)
        {
            left = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int x = 1 << collision.gameObject.layer;




        if (x == batMask.value)
        {
            jackAnimator.SetTrigger("Death");

            GameObject temp = Instantiate(pumpkin, gameObject.transform.position, Quaternion.identity, pumpkinManager.transform);

            gameObject.GetComponent<CircleCollider2D>().enabled = false;

            gameObject.GetComponentInParent<MoveTowardsPlayer>().Death();
            if (left)
                temp.GetComponent<Rigidbody2D>().velocity = new Vector3(-speedX, speedY, 0f);
            else
                temp.GetComponent<Rigidbody2D>().velocity = new Vector3(speedX, speedY, 0f);

        }
    }

}
