using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class cameraswitch : MonoBehaviour
    
{


    public GameObject camera1, camera2;
    //public GameObject Fordeactivate;
   // public GameObject fpscontroller;
    // Start is called before the first frame update
    void Start()
    {
        
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);



            gameObject.GetComponent<cameraswitch>().enabled = false;
            //gameObject.GetComponent<NewBehaviourScript>().enabled = true;


            Pickup pickup = GameObject.Find("FPSController").GetComponent<Pickup>();
            
            pickup.enabled = false;







            FirstPersonController firstPersonController = GameObject.Find("FPSController").GetComponent<FirstPersonController>();
            firstPersonController.enabled = false;
           
         
            
            firstPersonController.m_MouseLook.SetCursorLock(false);
            firstPersonController.m_MouseLook.UpdateCursorLock();




        }
        

    }

    
}
