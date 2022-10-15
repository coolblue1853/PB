using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MoreMountains.CorgiEngine
{
    public class RopeChecker : CharacterAbility
    {
        public GameObject player;
        GameObject nowRope;
        Rigidbody2D nowRopeRB;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (CharacterAbility.isRope == false)
            {
                if (nowRope != null)
                {
                    nowRope = null;
                    player.transform.parent = null;
                    
                }
                player.transform.localScale = new Vector3(1, 1, 1);
            }


            if(CharacterAbility.isRope == true)
            {
                if (nowRopeRB != null)
                {
                    if (Input.GetKey(KeyCode.LeftArrow))
                    {
                        nowRopeRB.AddForce(-nowRopeRB.transform.right * 20f);
                    }
                    if (Input.GetKey(KeyCode.RightArrow))
                    {
                        nowRopeRB.AddForce(nowRopeRB.transform.right * 20f);
                    }
                }
            }
       
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if(collision.transform.tag == "Rope")
            {
                if(CharacterAbility.isRope == true)
                {
                    nowRope = collision.gameObject;
                    nowRopeRB = collision.gameObject.GetComponent<Rigidbody2D>();

                    if(nowRope != null)
                        player.transform.SetParent(nowRope.transform, true);
                }
                
            }
        }

    }
}
