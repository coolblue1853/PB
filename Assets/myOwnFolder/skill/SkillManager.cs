using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MoreMountains.CorgiEngine
{
    public class SkillManager : MonoBehaviour
    {
        public Weapon initialWeapon;
        public Weapon rizingCut;


        public CharacterHandleWeapon min;

        // Start is called before the first frame update
        void Start()
        {

            min.CurrentWeapon.WeaponID = "nomal";
        }
        bool nowRight= true;

        bool once = false;
        // Update is called once per frame
        void Update()
        {


            if (Input.GetKeyDown(KeyCode.Z))
            {
                once = true;
                min.ChangeWeapon(rizingCut, "rizing");
                min.ShootStart();
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                if(once == true)
                {
                    once = false;

                    min.ChangeWeapon(initialWeapon, "nomal");
                }
             
   
            }
        }
    }
}
