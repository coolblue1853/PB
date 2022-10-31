using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MoreMountains.CorgiEngine
{
    public class rockSpponer : CharacterAbility
    {
        Rigidbody2D rigid;
        public float bulletSpeed;
        public Character direction;
        // Start is called before the first frame update
        void Start()
        {
            rigid = GetComponent<Rigidbody2D>();

            //
            direction = GameObject.FindWithTag("Player").GetComponent<Character>();
            

            if (direction.IsFacingRight)
                rigid.AddForce(new Vector2(1f,1f) * bulletSpeed);
            else
                rigid.AddForce(new Vector2(-1f, 1f) * bulletSpeed);

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
