using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class MainMenu : MonoBehaviour
{

    public void Bosque()
    {
        SceneManager.LoadScene("Escena Bosque");
    }

    public void Playa()
    {
        SceneManager.LoadScene("Escena Playa");
    }

   
    
 }
