using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    
    public Material skyBox1;
    public Material skyBox2;
    public ParticleSystem ps1;

    private Boolean estado;

    public void Estado(){

        if (estado == true){
            Dia();
            estado = false;
        }

        if (estado == false){
            Noche();
            estado=true;
        }
    }

    void Dia()
    {
        RenderSettings.skybox = skyBox2;
        print("10 am");
        ps1.Stop();
    }

    void Noche()
    {
        RenderSettings.skybox = skyBox1;
        print("6 PM");
        ps1.Play();
    }
    
}
