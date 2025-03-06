using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Songeul
{
    public class CamControl : MonoBehaviour
    {
        public GameObject player;
        private Camera cam;
        public float mouseSpeed;
        private float yRot;
        private float xRot;

        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            
            cam = Camera.main;
        }

        private void Update()
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;
            
            yRot += mouseX;
            xRot -= mouseY;
            
            xRot = Mathf.Clamp(xRot, -80f, 45f);
            cam.transform.rotation = Quaternion.Euler(xRot, yRot, 0);
            player.transform.rotation = Quaternion.Euler(0, yRot, 0);
        }
    }
}
