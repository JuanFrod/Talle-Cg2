using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clima : MonoBehaviour
{
   public ParticleSystem ps;
    
   

   public void cambiarClima()
    {
       if(ps.isEmitting)
        {
            ps.Stop();
          
        }
        else
        {
            ps.Play();
          
        }
    }
}
