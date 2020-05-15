using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posiciones : MonoBehaviour
{

    GameObject jugador;

    public GameObject clave;
    public GameObject guia;

    LinkedList<Vector3> TotalClave;
    LinkedList<Vector3> TotalGuia;


    float tiempoEsperaClave = 2.0f;
    float tiempoEsperaGuia = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");

        TotalGuia = new LinkedList<Vector3>();
        TotalClave = new LinkedList<Vector3>();
        StartCoroutine(ObtenerPosicionClave(jugador));
        StartCoroutine(ObtenerPosicionGuia(jugador));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H)){
            Debug.Log(TotalGuia.Count.ToString());
            Debug.Log(TotalClave.Count.ToString());
            
            foreach(Vector3 PosClave in TotalClave){
                Instantiate(clave,PosClave,new Quaternion(0,0,0,0));
            }

            foreach(Vector3 PosGuia in TotalGuia){
                Instantiate(guia,PosGuia,new Quaternion(0,0,0,0));
            }
        }
    }

    private IEnumerator ObtenerPosicionClave(GameObject pl)
    {
        Vector3 PosClave = new Vector3();
            while(true){
                yield return new WaitForSeconds(tiempoEsperaClave);
                PosClave = new Vector3(pl.transform.position.x,pl.transform.position.y,pl.transform.position.z);
                        if(TotalClave.Count > 1){
                            if(TotalClave.Last.Value != PosClave){
                                TotalClave.AddLast(PosClave);
                            }
                        }
                        else{
                                TotalClave.AddLast(PosClave);
                            }
            }
    }

    private IEnumerator ObtenerPosicionGuia(GameObject pl)
    {
        Vector3 PosGuia = new Vector3();
            while(true){
                yield return new WaitForSeconds(tiempoEsperaGuia);
                PosGuia = new Vector3(pl.transform.position.x,pl.transform.position.y,pl.transform.position.z);
                    if(TotalClave.Count >= 1){ 
                        if(TotalGuia.Count > 1){
                            if(TotalGuia.Last.Value != PosGuia){
                                TotalGuia.AddLast(PosGuia);
                            }
                        }
                        else{
                                TotalGuia.AddLast(PosGuia);
                            }
                    }
            }
    }

}
