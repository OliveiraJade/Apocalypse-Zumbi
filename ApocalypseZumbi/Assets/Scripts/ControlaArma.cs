﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaArma : MonoBehaviour
{
    public GameObject Bala;
    public GameObject canoDaArma;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Bala, canoDaArma.transform.position, canoDaArma.transform.rotation);
        }
    }
}
