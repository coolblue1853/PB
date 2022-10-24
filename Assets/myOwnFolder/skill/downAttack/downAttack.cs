using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using MoreMountains.Tools;

namespace MoreMountains.CorgiEngine
{

    public class downAttack : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            corgi = this.GetComponent<CorgiController>();
        }
        float duration = 0.5f;
        public Animator ani;
        CorgiController corgi;
         /* //전진을 위한 공격. 이건 그냥 앞으로 전진함.
         IEnumerator moveCoroutine(Vector2 endPos)
         {
             float startTime = Time.time;
             Vector2 startPos = this.transform.localPosition;


             while (Time.time - startTime <= duration)
             {

                 transform.localPosition = Vector2.Lerp(startPos, endPos, (Time.time - startTime) / duration);
                 yield return null;
             }

             transform.localPosition = endPos;


         }
         */

         IEnumerator moveCoroutine(Vector2 endPos)
        {
            float startTime = Time.time;
            Vector2 startPos = this.transform.localPosition;


            while (Time.time - startTime <= duration)
            {

                transform.localPosition = Vector3.Slerp(startPos, endPos, (Time.time - startTime) / duration);
                yield return null;
            }

            transform.localPosition = endPos;


        }
        bool one = false;

        IEnumerator timer()
        {
            corgi.enabled = false;
            ani.SetBool("jumpAttack", true);
            yield return new WaitForSecondsRealtime(0.8f);
            corgi.enabled = true;
            ani.SetBool("jumpAttack", false);
            one = false;
        }
        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyDown(KeyCode.S) && one == false)
            {
                one = true;
                //StartCoroutine(moveCoroutine());
                StartCoroutine(timer());
                transform.DOLocalJump(new Vector3(this.transform.localPosition.x + 3f, this.transform.localPosition.y, this.transform.localPosition.z), 3, 1, 0.8f, false);


            }

        }
    }

}