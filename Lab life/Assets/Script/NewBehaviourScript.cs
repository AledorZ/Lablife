using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject camera1, camera2;
   // public GameObject fpscontroller;

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
            
            gameObject.GetComponent<NewBehaviourScript>().enabled = false;

            gameObject.GetComponent<cameraswitch>().enabled = true;

            gameObject.GetComponent<MouseMove>().enabled = false;
            
            gameObject.GetComponent<Newpickup>().enabled = true;
            FirstPersonController firstPersonController = GameObject.Find("FPSController").GetComponent<FirstPersonController>();

            GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = true;


            firstPersonController.m_MouseLook.SetCursorLock(true);
            firstPersonController.m_MouseLook.UpdateCursorLock();


        }
        

    }
}
