using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float spinningSpeed = 0.1f;
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 1f;
    [SerializeField] float zAngle = 0;

    void Update()
    {
        SpinnerRotation();
    }

    void SpinnerRotation()
    {
        transform.Rotate(xAngle, yAngle, zAngle * spinningSpeed * Time.deltaTime);
    }

}
