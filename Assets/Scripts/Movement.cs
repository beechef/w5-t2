using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Update is called once per frame
    public float moveSpeed;
    public bool fixedUpdate;

    void Update()
    {
        if (!fixedUpdate)
            transform.Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0, 0));
    }

    private void FixedUpdate()
    {
        if (fixedUpdate)
            transform.Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0, 0));
    }
}