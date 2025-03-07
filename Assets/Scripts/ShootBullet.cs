using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Songeul
{
    public class ShootBullet : MonoBehaviour
    {
        CrossHair crosshair;
        public GameObject bullet;
        private void Update()
        {
            
        }

        void Shoot()
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(bullet, transform.position, transform.rotation);
                crosshair.Crosshair_animation();
            }
        }
    }
}
