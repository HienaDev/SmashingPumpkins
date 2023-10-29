using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnJacks : MonoBehaviour
{

    [SerializeField] private GameObject jack;

    [SerializeField] private float spawnTimer;
    private float justSpawned;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > justSpawned + spawnTimer)
        {
            Instantiate(jack, transform);
            justSpawned = Time.time;
        }
    }
}
