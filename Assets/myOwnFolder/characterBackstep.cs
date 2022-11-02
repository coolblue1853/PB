using UnityEngine;
using System.Collections;
using MoreMountains.Tools;
using DG.Tweening;
namespace MoreMountains.CorgiEngine
{

    public class characterBackstep : CharacterAbility
    {
        Vector2 back;
        public CorgiController controller;
        bool isFaceRight;
        float cooldown;
        bool endCool;

        CorgiController corgi;
        IEnumerator onCoolTime()
        {
            yield return new WaitForSecondsRealtime(0.23f);

            yield return new WaitForSecondsRealtime(0.8f);
            endCool = true;
        }

        // Start is called before the first frame update
        void Start()
        {
            corgi = this.GetComponent<CorgiController>();
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
                        //corgi.enabled = false;
                        endCool = false;
                        this.transform.DOLocalJump(new Vector3(this.transform.localPosition.x - 3f, this.transform.localPosition.y, this.transform.localPosition.z), 1, 1, 0.2f, false);
                        StartCoroutine(onCoolTime());

                    }
                    else
                    {
                        //corgi.enabled = false;
                        endCool = false;
                        this.transform.DOLocalJump(new Vector3(this.transform.localPosition.x + 3f, this.transform.localPosition.y, this.transform.localPosition.z), 1, 1, 0.2f, false);
                        StartCoroutine(onCoolTime());

                    }

                   

           
                }

            }

        }
    }
}
