using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject camera1, camera2;
   

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
            
            gameObject.GetComponent<NewBehaviourScript>().enabled = false;

            gameObject.GetComponent<cameraswitch>().enabled = true;
        }
        

    }
}
