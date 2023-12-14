using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDown : MonoBehaviour
{
    public float downSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * downSpeed * Time.deltaTime);
    }
}
