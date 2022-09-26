using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingCube : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private void FixedUpdate()
    {
        if (gameObject.transform.position.y < 4)
        {
            rb.AddForce(new Vector3(0, 100, 0));
        }
    }
}
