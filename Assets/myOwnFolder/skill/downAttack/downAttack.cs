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



        bool one = false;

        IEnumerator timer()
        {
            corgi.enabled = false;
            ani.SetBool("jumpAttack", true);
            yield return new WaitForSecondsRealtime(0.6f);
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
                transform.DOLocalJump(new Vector3(this.transform.localPosition.x + 3f, this.transform.localPosition.y, this.transform.localPosition.z), 3, 1, 0.6f, false);


            }

        }
    }

}