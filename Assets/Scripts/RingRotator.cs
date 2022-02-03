using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingRotator : MonoBehaviour
{
    [System.NonSerialized] public bool shouldRotate = true;

    float rotationSpeed;

    void Start()
    {
        rotationSpeed = Random.Range(-1f, 1f);
        if (rotationSpeed > -.2f && rotationSpeed < .2f)
        {
            rotationSpeed = Random.Range(.2f, 1f);
        }
    }

    void FixedUpdate()
    {
        if (shouldRotate)
        {
            transform.Rotate(0, rotationSpeed, 0, Space.Self);
        }
        
    }
}
