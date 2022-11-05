using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabbbitHole : MonoBehaviour
{
    public GameObject rabbit;
    int num;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.RandomRange(1, 4);

        for(int i = 0;i< num;i++)
        {
            GameObject rab = Instantiate(rabbit,this.gameObject.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
