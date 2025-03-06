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
        private float jumpPower = 35f;
        private int jumpCnt = 0;
        private Vector3 movement;
        
        private Rigidbody rigid;


        void Move()
        {
            float h =  Input.GetAxis("Horizontal");
            float v =  Input.GetAxis("Vertical");
            movement = transform.forward * v + transform.right * h;
            transform.position += movement.normalized * walkSpeed * Time.deltaTime;

            if (Input.GetKey(KeyCode.LeftControl) && movement.magnitude > 0.1f)
            {
                transform.position += movement * runSpeed * Time.deltaTime;
            }
        }

        void Jump()
        {
            if (jumpCnt < 2)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
                    jumpCnt++;
                }
            }
        }

        private void FixedUpdate()
        {
            Move();
        }

        private void Update()
        {
            Jump();
            
            //점프 후 착지를 빠르게 해주기위한 코드
            Physics.gravity = new Vector3(0, -50f, 0);
        }

        private void Start()
        {
            rigid = GetComponent<Rigidbody>();
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Object"))
            {
                jumpCnt = 0;
            }
        }
    }
}
