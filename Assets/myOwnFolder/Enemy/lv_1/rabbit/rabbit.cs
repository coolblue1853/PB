using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MoreMountains.CorgiEngine
{
    public class rabbit : MonoBehaviour
    {
        public AIActionSetTransformAsTarget target;
        public 

        // Start is called before the first frame update
        void Start()
        {
            target.TargetTransform = this.transform.parent;

        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerStay2D(Collider2D collision)
        {

        }



    }
}