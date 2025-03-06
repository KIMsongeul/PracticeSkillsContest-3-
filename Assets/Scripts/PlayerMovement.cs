using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Songeul
{
    public class PlayerMovement : MonoBehaviour
    {
        private float walkSpeed = 4f;
        private float runSpeed = 6f;
        private float jumpPower;
        private int jumpCnt;
        private Vector3 movement;
        
        private Rigidbody rigid;


        void Move()
        {
            movement.x =  Input.GetAxis("Horizontal");
            movement.z =  Input.GetAxis("Vertical");
            movement.Normalize();
            rigid.velocity = movement * walkSpeed;

            if (Input.GetKey(KeyCode.LeftControl) && movement.magnitude > 0.1f)
            {
                rigid.velocity = movement * runSpeed;
            }
            
        }

        private void FixedUpdate()
        {
            Move();
        }

        private void Start()
        {
            rigid = GetComponent<Rigidbody>();
        }
    }
}
