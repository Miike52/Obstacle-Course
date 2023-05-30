using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int wallHits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            wallHits++;
            Debug.Log("You've bumped into the wall this many times: " + wallHits);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

    }

}
