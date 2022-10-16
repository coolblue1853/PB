using UnityEngine;
using System.Collections;
using MoreMountains.Tools;

namespace MoreMountains.CorgiEngine
{

    public class characterBackstep : CharacterAbility
    {
        Vector2 back;
        public CorgiController controller;
        bool isFaceRight;
        float cooldown;
        bool endCool;

        IEnumerator onCoolTime()
        {
            yield return new WaitForSecondsRealtime(1f);
            endCool = true;
        }

        // Start is called before the first frame update
        void Start()
        {
            isFaceRight = true;
            endCool = true;
            controller =this.GetComponent<CorgiController>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                isFaceRight = true;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                isFaceRight = false;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                if(endCool == true)
                {
                    CharacterAbility.isAction = true;
                    CharacterAbility.removeStemina(dashSt);
                    if (isFaceRight)
                    {

                        endCool = false;
                        controller.AddVerticalForce(9);
                        controller.AddHorizontalForce(-100);
                        StartCoroutine(onCoolTime());

                    }
                    else
                    {

                        endCool = false;
                        controller.AddVerticalForce(9);
                        controller.AddHorizontalForce(+100);
                        StartCoroutine(onCoolTime());

                    }

                   

           
                }

            }

        }
    }
}
