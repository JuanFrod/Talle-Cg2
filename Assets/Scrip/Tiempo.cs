using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    
    public Material skyBox1;
    
    public Material skyBox2;
   
    
    public ParticleSystem ps1;
    void Start()
    {
        RenderSettings.skybox = skyBox1;
        ps1.Stop();
    }

    void Dia()
    {


        RenderSettings.skybox = skyBox2;
        print("10 am");
        ps1.Play();


    }

    void Noche()
    {


        RenderSettings.skybox = skyBox1;
        print("6 PM");
        ps1.Stop();


    }
    
}
