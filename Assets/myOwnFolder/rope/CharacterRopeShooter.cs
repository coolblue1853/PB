using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MoreMountains.CorgiEngine
{
    public class CharacterRopeShooter : CharacterAbility
    {
        public float deg;
        public float turretSpeed;
        public GameObject turret;
        float rad;
        public GameObject rope;

        bool onceR;
        bool onceL;
        // Start is called before the first frame update
        void Start()
        {
            onceR = true;
            onceL = false;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && onceL == false)
            {
                onceL = true;
                onceR = false;
                deg = 180 - deg;
                rad = deg * Mathf.Deg2Rad;
                turret.transform.localPosition = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));

                turret.transform.eulerAngles = new Vector3(0, 0, deg);
                CharacterAbility.ropeDeg = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) && onceR == false)
            {
                onceR = true;
                onceL = false;
                deg = 180 - deg;
                rad = deg * Mathf.Deg2Rad;
                turret.transform.localPosition = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));

                turret.transform.eulerAngles = new Vector3(0, 0, deg);
                CharacterAbility.ropeDeg = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                deg = deg + Time.deltaTime * turretSpeed;
                rad = deg * Mathf.Deg2Rad;
                turret.transform.localPosition = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));

                turret.transform.eulerAngles = new Vector3(0, 0, deg);
                CharacterAbility.ropeDeg = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                deg = deg - Time.deltaTime * turretSpeed;
                rad = deg * Mathf.Deg2Rad;
                turret.transform.localPosition = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
                turret.transform.eulerAngles = new Vector3(0, 0, deg);
                CharacterAbility.ropeDeg = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                GameObject go = Instantiate(rope);
                go.transform.position = turret.transform.position;
            }
        }
    }
}
