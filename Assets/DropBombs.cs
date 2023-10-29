using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBombs : MonoBehaviour
{

    [SerializeField] private GameObject bombPoint;

    [SerializeField] private GameObject pumpkin;

    [SerializeField] private float[] times;
    private float nextTime;
    private float justExploded;
    private bool dropped = true;

    private GameObject pumpkinManager;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        pumpkinManager = FindAnyObjectByType<PumpkinManager>().gameObject;
        nextTime = times[Random.Range(0, times.Length)];
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(nextTime);
        Debug.Log("drop?" + (Time.time - justExploded > nextTime));


        if (Time.time - justExploded > nextTime && dropped)
        {
            animator.SetTrigger("Drop");
            dropped = false;
            
        }
    }

    public void DropBomb()
    {


        GameObject temp = Instantiate(pumpkin, gameObject.transform.position, Quaternion.identity, pumpkinManager.transform);
        justExploded = Time.time;

        nextTime = times[Random.Range(0, times.Length)];
        dropped = true;

    }
}
