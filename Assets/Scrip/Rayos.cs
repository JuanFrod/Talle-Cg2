using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Rayos : MonoBehaviour
{
    [SerializeField]
    public Camera cam;
    [SerializeField]
    public GameObject palm;

    string name1;
    void Start()
    {
        
        cam = GetComponent<Camera>();
    }

    void Update()
    {
    //Check if mouse is clicked
    if (Input.GetMouseButtonDown(0))
    {
        RaycastHit hit;
        name1 = (palm.name);
            //Get ray from mouse postion
            Ray rayCast = Camera.main.ScreenPointToRay(Input.mousePosition);

        //Raycast and check if any object is hit
        if (Physics.Raycast(rayCast, out hit))
        {

                
            //Check which tag is hit
            if (hit.collider.name == name1)
            {
                    print(hit.collider.name);
                    print(hit.collider.transform.position);
            }
        }
    }
  }

}