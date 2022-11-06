using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfSummor : MonoBehaviour
{
    public GameObject w;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(w, new Vector2(this.transform.localPosition.x, this.transform.localPosition.y), this.transform.rotation);

        Destroy(this.gameObject);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
