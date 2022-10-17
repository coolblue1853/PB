using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MoreMountains.CorgiEngine
{
    public class SkillManager : MonoBehaviour
    {
        public Weapon initialWeapon;
        public Weapon rizingCut;
        float rizingCut_CoolDown = 2f;
        bool rizingCut_CoolDownEnd = true;
        public CharacterHandleWeapon min;

        // Start is called before the first frame update
        void Start()
        {


        }
        bool nowRight= true;
        IEnumerator cooldown()
        {

               yield return new WaitForSecondsRealtime(rizingCut_CoolDown);
            rizingCut_CoolDownEnd = true;
        }
        bool once = false;
        // Update is called once per frame
        void Update()
        {


            if (Input.GetKeyDown(KeyCode.Z) && rizingCut_CoolDownEnd)
            {
                rizingCut_CoolDownEnd = false;
                StartCoroutine(cooldown());
                once = true;
                min.ChangeWeapon(rizingCut, "rizing");
                min.ShootStart();
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                if(once == true)
                {
                    once = false;
                    DataBaseManager.changeNomalAttack = true;
                    min.ChangeWeapon(initialWeapon, "nomal");



                }
             
   
            }
        }
    }
}
