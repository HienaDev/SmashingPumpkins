using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleWithMusic : MonoBehaviour
{

    [SerializeField] private float BPM;

    private float timeBetweenNotes;

    private float justBopped;
    private bool bop = true;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        timeBetweenNotes = 1 / (BPM / 60);
        Debug.Log(timeBetweenNotes);    
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Time.time - justBopped > timeBetweenNotes)
        {
            
            bop = true;
        }

        if(bop == true)
        {
            animator.SetTrigger("Bop");
            bop = false;
            justBopped = Time.time;
        }
        

    }
}
