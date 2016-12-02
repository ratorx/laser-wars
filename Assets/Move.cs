﻿using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
	public float speed = 1.5f;

    void Update()
    {
        var move = new Vector3(0, Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;
    }
}