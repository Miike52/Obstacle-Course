using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mRenderer;
    Rigidbody mRigidbody;

    [SerializeField] float timeToWait = 3f;
    

    // Start is called before the first frame update
    void Start()
    {
        mRenderer = GetComponent<MeshRenderer>();

        mRenderer.enabled = false;

        mRigidbody = GetComponent<Rigidbody>();

        mRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        TimeCounter();
    }

    public void TimeCounter()
    {
        if (Time.time > timeToWait)
        {
            Debug.Log("Yay, " + timeToWait + " seconds has elapsed!");
            mRenderer.enabled = true;
            mRigidbody.useGravity = true;
        }
    }
}
