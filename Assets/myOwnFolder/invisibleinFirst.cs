﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisibleinFirst : MonoBehaviour
{
    // Start is called before the first frame update

    private void Awake()
    {
        this.gameObject.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
