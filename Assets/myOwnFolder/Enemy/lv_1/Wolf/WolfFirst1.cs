using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
namespace MoreMountains.CorgiEngine
{
    public class WolfFirst1 : MonoBehaviour
    {
        Animator ani;
        MMHealthBar bar;
        public GameObject inside;
        // Start is called before the first frame update
        private void Awake()
        {

            StartCoroutine(oneSec());
        }
        IEnumerator oneSec()
        {
            yield return new WaitForSeconds(0.3f);
            inside.SetActive(true);
            inside.transform.parent = null;
            Destroy(this.gameObject);
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