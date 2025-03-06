using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Songeul
{
    public class ShootBullet : MonoBehaviour
    {
        CrossHair crosshair;
        private void Update()
        {
            
        }

        void Shoot()
        {
            if (Input.GetMouseButton(0))
            {
                crosshair.Crosshair_animation();
            }
        }
    }
}
