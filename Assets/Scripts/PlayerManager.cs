using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

namespace Songeul
{
    public class PlayerManager : MonoBehaviour
    {
        public Slider slider;
        HpSystem hpSystem;

        private void Start()
        {
            hpSystem = gameObject.AddComponent<HpSystem>();
            hpSystem.damage = 40f;
            hpSystem.maxHp = 100f;
        }

        private void Update()
        {
            slider.value = hpSystem.currentHp;
        }

        private void OnCollisionEnter(Collision other)
        {
            // if (other.gameObject.CompareTag("EnemyAttack"))
            // {
            //     
            // }
        }
    }
}
