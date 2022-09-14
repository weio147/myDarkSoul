using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SG
{
    public class PlayerInventory : MonoBehaviour
    {
        WeaponSlotManager weaponSlotManger;
        public WeaponItem rightWeapon;
        public WeaponItem leftWeapon;
        private void Awake()
        {
            weaponSlotManger = GetComponentInChildren<WeaponSlotManager>();
        }
        private void Start()
        {
            weaponSlotManger.LoadWeaponOnSlot(rightWeapon, false);
            weaponSlotManger.LoadWeaponOnSlot(leftWeapon, true);
        }
    }
}

