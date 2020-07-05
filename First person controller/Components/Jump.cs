﻿using UnityEngine;

namespace VitefFirstPerson
{
    public class Jump : MonoBehaviour
    {
        [SerializeField]
        GroundCheck groundCheck;
        Rigidbody rigidbody;
        public float jumpStrength = 2;


        void Reset()
        {
            groundCheck = GetComponentInChildren<GroundCheck>();
            if (!groundCheck)
                groundCheck = GroundCheck.Create(transform);
        }

        void Awake()
        {
            rigidbody = GetComponent<Rigidbody>();
        }

        void LateUpdate()
        {
            if (Input.GetButtonDown("Jump") && groundCheck.isGrounded)
                rigidbody.AddForce(Vector3.up * 100 * jumpStrength);
        }
    }
}