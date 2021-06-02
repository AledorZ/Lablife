using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraswitch : MonoBehaviour
    
{
    public GameObject camera1, camera2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
           
            gameObject.GetComponent<NewBehaviourScript>().enabled = true;

            gameObject.GetComponent<cameraswitch>().enabled = false;
        }
        

    }
}
