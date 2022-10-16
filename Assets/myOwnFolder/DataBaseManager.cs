using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace MoreMountains.CorgiEngine
{
    public class DataBaseManager : MonoBehaviour
{
        public static bool 채팅줄끝남 = false;
        public static float attackInterval;


        static public DataBaseManager instance;

        private void Awake()
        {
            if (instance != null)
            {
                Destroy(this.gameObject);
            }
            else
            {
                DontDestroyOnLoad(this.gameObject);
                instance = this;
            }






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