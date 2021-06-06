using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float range;
    public GameObject parent;
    public Camera Camera;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PickUP();
        }
       
            

    }

    void PickUP()
    {
        RaycastHit hit;
        if(Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, range))
        {
           
        }
    }
}
