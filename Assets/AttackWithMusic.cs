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

    private float justBopped = 0f;
    private float justBoppedBefore;
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

        Debug.Log((Time.time > justBoppedBefore + timeBetweenNotes - (gracePeriod / 2) && Time.time < justBopped + (gracePeriod / 2)));

        /*if (Input.GetKeyDown(attack) &&*/ if((Time.time > justBoppedBefore + timeBetweenNotes - (gracePeriod / 2) && Time.time < justBopped + (gracePeriod / 2)) && canAttack)
        {
            canAttack = false;
            playerAnimator.SetTrigger("Attack");
            
            Debug.Log(justBoppedBefore + timeBetweenNotes - (gracePeriod / 2));
            Debug.Log(justBopped + (gracePeriod / 2));  
        }

        if (Time.time >= justBopped + (gracePeriod / 2)) canAttack = true;

        if (bop == true)
        {
            bop = false;

            justBoppedBefore = justBopped;
            justBopped = Time.time;
        }


    }

    public void EnableAttack(bool attack) => canAttack = attack;
}
