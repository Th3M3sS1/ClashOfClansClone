﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camp : BuildingsManager
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log(Time.deltaTime);
    }
}
