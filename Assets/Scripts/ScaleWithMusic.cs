using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleWithMusic : MonoBehaviour
{

    [SerializeField] private float BPM;
    
    [SerializeField] private Color[] epilepsy;

    private int colorIndex = 0;

    [SerializeField] private float epilepsyTime;

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
        

        if (Time.timeSinceLevelLoad - justBopped > timeBetweenNotes)
        {
            
            


            bop = true;
        }
            
        if(bop == true)
        {
            if (Time.timeSinceLevelLoad > epilepsyTime)
                animator.SetTrigger("Epilepsy");
            else
                animator.SetTrigger("Bop");

            bop = false;
            justBopped = Time.timeSinceLevelLoad;
        }
        

    }

    public void EnableAttack() => GetComponentInParent<AttackWithMusic>().EnableAttack(true);

    public void DisableAttack() => GetComponentInParent<AttackWithMusic>().EnableAttack(false);

    public void ChangeColor()
    {
        if (Time.timeSinceLevelLoad > epilepsyTime)
        { 
            if (colorIndex == epilepsy.Length)
                colorIndex = 0;

            Debug.Log("colori: " + colorIndex);
            Debug.Log("length: " + epilepsy.Length);

            try { GetComponent<SpriteRenderer>().color = epilepsy[colorIndex]; }
            catch { GetComponentInChildren<SpriteRenderer>().color = epilepsy[colorIndex]; }

            colorIndex += 1;
            }
    }
}
