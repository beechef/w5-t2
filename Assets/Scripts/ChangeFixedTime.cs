using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFixedTime : MonoBehaviour
{
    public float fixedTime = 0.02f;

    private void Update()
    {
        Time.fixedDeltaTime = fixedTime;
    }
}
