using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MoreMountains.CorgiEngine
{
    public class ropeSpponer : CharacterAbility
    {
        Rigidbody2D rigid;
        public float bulletSpeed;
        public GameObject ropset;
        // Start is called before the first frame update
        void Start()
        {
            rigid = GetComponent<Rigidbody2D>();

            //
            rigid.AddForce(CharacterAbility.ropeDeg * bulletSpeed);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.transform.tag == "setRope")
            {
                Destroy(rigid);
                ropset.SetActive(true);

            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
