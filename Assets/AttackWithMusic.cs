using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackWithMusic : MonoBehaviour
{
    [SerializeField] GameObject[] Walls;

    [SerializeField] private float BPM;

    [SerializeField] private KeyCode attack;

    private Animator playerAnimator;

    [SerializeField] private float gracePeriod;

    private float timeBetweenNotes;

    private float justBopped;
    private bool bop = true;

    private bool canAttack = false;


    // Start is called before the first frame update
    void Start()
    {
        timeBetweenNotes = 1 / (BPM / 60);
        playerAnimator = GetComponent<Animator>();
        Debug.Log(timeBetweenNotes);    
    }

    // Update is called once per frame
    void Update()
    {


        if (Time.time - justBopped > timeBetweenNotes)
        {

            bop = true;
        }


        //if (Input.GetKeyDown(attack) && (Time.time > justBopped + timeBetweenNotes - gracePeriod || Time.time < justBopped)
        //{
        //    playerAnimator.SetTrigger("Attack");
        //}

        if (bop == true)
        {
            bop = false;
            justBopped = Time.time;
        }


    }

    public void EnableAttack(bool attack) => canAttack = attack;
}
