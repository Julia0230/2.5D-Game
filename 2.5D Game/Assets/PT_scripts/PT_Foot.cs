﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_Foot : MonoBehaviour {

    public bool isGrounded = false;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Grounded");
        isGrounded = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isGrounded = false;
    }
}
