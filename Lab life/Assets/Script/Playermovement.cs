using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public CharacterController Controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public Transform groundcheck;
    public float grounddistance = 0.4f;
    public LayerMask groundMask;
    public float jumphight = 3f;
    Vector3 velocity;
    bool isGrounded;
    public float health = 100f;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundcheck.position, grounddistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        Controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumphight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        Controller.Move(velocity * Time.deltaTime);
        
    }
    void OnCollisionEnter(Collision col)
    {
        
    }


}
