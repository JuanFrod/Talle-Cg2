using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CargarPalmeras : MonoBehaviour
{
    public GameObject Palmera;
    Vector3 PosPalmera;
    LinkedList<Vector3> PosicionesPalmeras;

    // Start is called before the first frame update
    void Start()
    {
        PosicionesPalmeras = new LinkedList<Vector3>();
        PosPalmera = new Vector3();

        CrearPosPalmeras();
        CargarLasPalmeras();
        PonerPalmeras(PosicionesPalmeras);

    }
    

    public static Vector3 StringToVector3(string sVector)
     {
         // Remove the parentheses
         if (sVector.StartsWith ("(") && sVector.EndsWith (")")) {
             sVector = sVector.Substring(1, sVector.Length-2);
         }
 
         // split the items
         string[] sArray = sVector.Split(',');
         float x = float.Parse(sArray[0]);
         float y = float.Parse(sArray[1]);
         float z = float.Parse(sArray[2]);

         // store as a Vector3
         Vector3 result = new Vector3(x,y,z);
         return result;
     }

    private void CrearPosPalmeras(){
        
        StreamWriter escribir = new StreamWriter(@"\MyTest.txt");
            try
            {
                escribir.WriteLine("(211,4,236)");
                escribir.WriteLine("(228,5,233)");
                escribir.WriteLine("(213,4,239)");
                escribir.WriteLine("(222,4,217)");
                escribir.WriteLine("(231,3,229)");
                escribir.WriteLine("(232,3,233)");
                escribir.WriteLine("(230,6,237)");
                escribir.WriteLine("(219,3,217)");
                escribir.WriteLine("(208,4,235)");
                escribir.WriteLine("(209,4,238)");
                escribir.WriteLine("(222,4,213)");

            }
            catch
            {
                Debug.Log("Error");
            }
            escribir.Close();
    }

    private void CargarLasPalmeras(){

        StreamReader leer = new StreamReader(@"\MyTest.txt");
           
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    PosPalmera = StringToVector3(linea);
                    PosicionesPalmeras.AddLast(PosPalmera);
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                Debug.Log("Error");
            }

    }

    private void PonerPalmeras(LinkedList<Vector3> pl){

        foreach(Vector3 PosPalmera in pl){
            Instantiate(Palmera,PosPalmera,new Quaternion(0,0,0,0));
        }

    }

}
