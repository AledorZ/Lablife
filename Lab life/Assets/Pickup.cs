using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform Position;
    public float distance = 10f;
     GameObject currentpickup;
     GameObject Things;

    bool pickupable;


    void Update()
    {
        checkcanpickup();
        if (pickupable)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                

                    pickup();

                
            }
        }
        if (currentpickup != null)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                Drop();
            }
        }
    }

    private void checkcanpickup()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))
        {


            if (hit.transform.tag != "Pickupable")
            {
                pickupable = false;
            }
            else
            {
                
                pickupable = true;
                Things = hit.transform.gameObject;
            }
        }
    }
    private void pickup()
    {
        currentpickup = Things;
        currentpickup.transform.position = Position.position;
        currentpickup.transform.parent = Position;
        currentpickup.transform.localEulerAngles = new Vector3(0, 0, 0);
        currentpickup.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void Drop()
    {
        currentpickup.transform.parent = null;
        currentpickup.GetComponent<Rigidbody>().isKinematic = false;
        currentpickup = null;
    }





}
