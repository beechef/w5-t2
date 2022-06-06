using System;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    private Rigidbody rig;
    public Vector3 speed;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rig.AddForce(speed, ForceMode.Force);
    }
}