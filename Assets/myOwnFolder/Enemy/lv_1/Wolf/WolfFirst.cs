using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
namespace MoreMountains.CorgiEngine
{
    public class WolfFirst : MonoBehaviour
    {
        Animator ani;
        MMHealthBar bar;
        public GameObject inside;
        // Start is called before the first frame update
        private void Awake()
        {
            ani = this.GetComponent<Animator>();
            bar = this.GetComponent<MMHealthBar>();
            ani.SetBool("Alive", true);
            StartCoroutine(oneSec());
        }
        IEnumerator oneSec()
        {
            yield return new WaitForSeconds(0.3f);


        }


        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}