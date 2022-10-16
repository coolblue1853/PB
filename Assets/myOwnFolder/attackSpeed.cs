using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MoreMountains.CorgiEngine
{
    public class attackSpeed : Health
    {
        float attSpd;

        public MeleeWeapon weapon1;
        public MeleeWeapon weapon2;
        public MeleeWeapon weapon3;

        float a1;
        float a2;
        float a3;

        public Animator ani;
        // Start is called before the first frame update
        void Start()
        {
            attSpd = 1;
            ani = GameObject.Find("Model").GetComponent<Animator>();

            weapon1.TimeBetweenUses = 0.4f;
            weapon2.TimeBetweenUses = 0.5f;
            weapon3 .TimeBetweenUses = 0.5f;

            weapon1.ActiveDuration = 0.4f;
            weapon2.ActiveDuration = 0.5f ;
            weapon3.ActiveDuration = 0.5f;

            weapon1.changeInvincibility(weapon1.ActiveDuration+0.05f);
            weapon2.changeInvincibility(weapon1.ActiveDuration + 0.05f);
            weapon3.changeInvincibility(weapon3.ActiveDuration + 0.05f);





            ani.SetFloat("attackSpeed", 1);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                
            }

            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                restting();
                attSpd = 0.1f;
                weapon1.TimeBetweenUses = 0.4f * attSpd;
                weapon2.TimeBetweenUses = 0.5f * attSpd;
                weapon3.TimeBetweenUses = 0.5f * attSpd;
                weapon1.ActiveDuration = 0.4f * attSpd;
                weapon2.ActiveDuration = 0.5f * attSpd;
                weapon3.ActiveDuration = 0.5f * attSpd;

                weapon1.changeInvincibility(weapon1.ActiveDuration + 0.05f);
                weapon2.changeInvincibility(weapon1.ActiveDuration + 0.05f);
                weapon3.changeInvincibility(weapon3.ActiveDuration + 0.05f);

                ani.SetFloat("attackSpeed", ani.GetFloat("attackSpeed") / attSpd);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                restting();
                attSpd = 0.6f;
                weapon1.TimeBetweenUses = 0.4f * attSpd;
                weapon2.TimeBetweenUses = 0.5f * attSpd;
                weapon3.TimeBetweenUses = 0.5f * attSpd;

                weapon1.ActiveDuration = 0.4f * attSpd;
                weapon2.ActiveDuration = 0.5f * attSpd;
                weapon3.ActiveDuration = 0.5f * attSpd;

                weapon1.changeInvincibility(weapon1.ActiveDuration + 0.05f);
                weapon2.changeInvincibility(weapon1.ActiveDuration + 0.05f);
                weapon3.changeInvincibility(weapon3.ActiveDuration + 0.05f);
                ani.SetFloat("attackSpeed", ani.GetFloat("attackSpeed") / attSpd);
            }


        }

        private void restting()
        {
            attSpd = 1;
            weapon1.TimeBetweenUses = 0.4f;
            weapon2.TimeBetweenUses = 0.5f;
            weapon3.TimeBetweenUses = 0.5f;

            weapon1.ActiveDuration = 0.4f;
            weapon2.ActiveDuration = 0.5f;
            weapon3.ActiveDuration = 0.5f;


            weapon1.InvincibilityDuration = weapon1.ActiveDuration;
            weapon2.InvincibilityDuration = weapon2.ActiveDuration;
            weapon3.InvincibilityDuration = weapon3.ActiveDuration;


            ani.SetFloat("attackSpeed", 1);

        }
    }
}
