using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace MoreMountains.CorgiEngine
{
    public class steminaUIManager : CharacterAbility
    {

        public Image stemniabar;
        
        // Start is called before the first frame update
        void Start()
        {
            CharacterAbility.nowStemina = 1000;
            CharacterAbility.fullStemina = 1000;
            recoveryAmount = 50;
        }

        // Update is called once per frame

        public float recoveryAmount = 50;
        bool oneTime= false;
        void restCheck()
        {
            if ((isAction == true) && oneTime== false)
            {
                CharacterAbility.isAction = false;
                Debug.Log("stay");
                oneTime = true;
                CharacterAbility.isRestOneSec = false;
                StartCoroutine(oneSecChecker());
            }
        }

        IEnumerator oneSecChecker()
        {

            yield return new WaitForSecondsRealtime(1f);
            isRestOneSec = true;
            oneTime = false;
        }





        void Update()
        {
            restCheck();
            if (CharacterAbility.nowStemina < CharacterAbility.fullStemina)
            {
                if(CharacterAbility.isAction == false)
                {
       
                    if (CharacterAbility.isRestOneSec == false)
                    {
                        CharacterAbility.nowStemina = CharacterAbility.nowStemina + Time.deltaTime * recoveryAmount;
                    }
                    else if (CharacterAbility.isRestOneSec == true)
                    {
                        CharacterAbility.nowStemina = CharacterAbility.nowStemina + Time.deltaTime * recoveryAmount *4;
                    }



                }

            }


            stemniabar.fillAmount = CharacterAbility.nowStemina / CharacterAbility.fullStemina;
        }



    }
}
