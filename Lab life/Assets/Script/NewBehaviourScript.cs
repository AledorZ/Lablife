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

            //gameObject.GetComponent<Mouselock>().enabled = false;

            //GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = true;


        }
        

    }
}
