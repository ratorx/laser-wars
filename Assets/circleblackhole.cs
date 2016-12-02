﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleblackhole : MonoBehaviour 
{

	private float RotateSpeed = 0.5f;
	private float Radius = 2.5f;

	private Vector2 _centre;
	private float _angle;

	private void Start()
	{
		_centre = transform.position;
	}

	private void Update()
	{

		_angle += RotateSpeed * Time.deltaTime;

		var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
		transform.position = _centre + offset;
	}



}
