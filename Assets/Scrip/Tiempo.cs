using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    
    public Material skyBox1;
    
    public Material skyBox2;
    int contador = 0;
    Boolean change = false;
    public ParticleSystem ps1;
    void Start()
    {
        RenderSettings.skybox = skyBox1;
        ps1.Stop();
    }

    


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (contador == 0)
            {
                if (change == false)
                
                    RenderSettings.skybox = skyBox2;
                    contador = 1;
                    change = true;
                print("Se a cambiado el clima");
                ps1.Play();
            }
            else
            {

                if (change == true)
                RenderSettings.skybox = skyBox1;
                contador = 0;
                change = false;
                print("Se a cambiado el clima");
                ps1.Stop();
            }

        }
    }

    
}
