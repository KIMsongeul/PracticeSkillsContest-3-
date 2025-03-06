using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Songeul
{
    public class HpSystem : MonoBehaviour
    {
        public float maxHp;
        public float currentHp;
        public float damage;
        
        public bool isDead = false;


        private void Start()
        {
            currentHp = maxHp;
        }

        public void Damage(float damage)
        {
            currentHp -= damage;
            if (currentHp < 0)
            {
                isDead = true;
            }
        }
    }
}
