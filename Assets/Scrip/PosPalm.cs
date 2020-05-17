using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosPalm : MonoBehaviour
{

    GameObject palma;
    float x;
    float z;
    float y = 12;
    int i = 0;
    string path = @"C:\Users\Administrador\Documents\GitHub\Talle-Cg2\MyTest.txt";
    LinkedList<Vector3> AlmacenarPalmas;
    // Start is called before the first frame update
    void Start()
    {
        AlmacenarPalmas = new LinkedList<Vector3>();
        Vector3 PosClave = new Vector3();

        while (true)
        {
            System.Random random = new System.Random();
            if (i <= 12)
            {
                x = random.Next(-11, 41);
                z = random.Next(-2, 32);
                PosClave = new Vector3(x, y, z);
                AlmacenarPalmas.AddLast(PosClave);
                i++;
            }


        }

        print(AlmacenarPalmas);
    }

    /* void CrearArchivo()
     {
         AlmacenarPalmas = new LinkedList<Vector3>();
         Vector3 PosClave = new Vector3();


         if (!File.Exists(path))
         {
             // Create a file to write to.
             using (StreamWriter sw = File.CreateText(path))
             {


                 while (true)
                 {
                     System.Random random = new System.Random();
                     if (i <= 12)
                     {
                         x = random.Next(-11, 41);
                         z = random.Next(-2, 32);
                         PosClave = new Vector3(x, y, z);
                         AlmacenarPalmas.AddLast(PosClave);

                         i++;
                     }


                 }

                 sw.Write(AlmacenarPalmas);

             }



         }


        }



     void LeerArchivo()
     {
         using (StreamReader sr = File.OpenText(path))
         {
             string s = "";
             while ((s = sr.ReadLine()) != null)
             {
                 Console.WriteLine(s);
             }
         }
     }


         // Update is called once per frame
         void Update()
         {






         }
     }*/

}