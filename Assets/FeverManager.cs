using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeverManager : MonoBehaviour
{

    [SerializeField] private AttackWithMusic attackScript;
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(attackScript.GetTiming());
        if (Input.GetMouseButtonDown(0))
        {

            if(attackScript.GetTiming())
            {
                animator.SetTrigger("WellT");
            }
            else
            {
                animator.SetTrigger("BadT");
            }
        }
    }
}
