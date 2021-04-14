using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   // private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;
    void Start()
    {
       // controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveForward = Time.deltaTime * forwardSpeed;
        
        transform.Translate(0, -moveForward,0 );
    }
    private void FixedUpdate()
    {
       // controller.Move(direction * Time.fixedDeltaTime);
    }
}
