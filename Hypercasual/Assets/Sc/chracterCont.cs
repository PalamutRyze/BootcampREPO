using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chracterCont : MonoBehaviour
{
   private CharacterController characterController;

   public float Speed = 5f;
   Rigidbody rb;
   public Vector3 boxSize;
   public float maxDistance;
   public LayerMask layerMask;

     void Start()
     {
         characterController = GetComponent<CharacterController>();
         rb = GetComponent<Rigidbody>();
     }

     private void Update()
     {
         Vector3 move = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
         
         characterController.Move(move * Time.deltaTime * Speed);
         
         if(Input.GetKeyDown(KeyCode.Space))
         {
             rb.AddForce(transform.up*5,ForceMode.Impulse);
         }
     }

     private void OnDrawGizmos()
     {
         Gizmos.color = Color.red;
         Gizmos.DrawCube(transform.position-transform.up*maxDistance,boxSize);
     }

     bool GroundCheck()
     {
         if (Physics.BoxCast(transform.position,boxSize,-transform.up, transform.rotation, maxDistance, layerMask))
         {
             return true;
         }
         else
         {
             return false;
         }
     }
}
