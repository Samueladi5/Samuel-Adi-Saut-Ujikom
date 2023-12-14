using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectCow;
    public float intervalSpawn = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjek", 0f, intervalSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(objectCow, transform.position, Quaternion.identity);
    }
}
