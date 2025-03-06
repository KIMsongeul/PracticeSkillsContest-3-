using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Songeul
{
    public class CrossHair : MonoBehaviour
    {
        private Animator anim;
        
        public void Crosshair_animation()
        {
            anim.SetBool("Shoot",true);
        }
    }
}
