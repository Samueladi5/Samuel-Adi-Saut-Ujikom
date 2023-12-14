using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TembokDestroy : MonoBehaviour
{
    public string targetTag = "Animal";
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            Destroy(gameObject);
        }

    }
}
