﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Platformer2D
{
    [RequireComponent(typeof(Rigidbody))]
    public class Controller2D : MonoBehaviour
    {
        public float accelerate = 20f;
        public float jumpHeight = 10f;

        private Rigidbody rigid;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();
        }

        // Handles movement depending on what the given
        // 'inputH' value is. (-1 = A, 0 = Nothing, 1 = D)
        public void Move(float inputH)
        {
            rigid.AddForce(transform.right * inputH * accelerate);
        }

        // Adds a force in the up direction
        public void Jump()
        {
            rigid.AddForce(transform.up * jumpHeight, ForceMode.Impulse);
        }
    }
}