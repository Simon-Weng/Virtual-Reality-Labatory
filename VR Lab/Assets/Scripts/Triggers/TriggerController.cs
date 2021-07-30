using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    //trigger = Lefthand
    public Transform hand;

    private Rigidbody rb;
    private Collider HandCollider;

    private Vector3 pointOfContact;

    float distance;

    private Vector3 contactPoint;




    // Start is called before the first frame update
    void Start()
    {
     //gets the collider of the public object ( in this case the left hand )
        HandCollider = hand.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    //set intital point of contact when trigger is entered 
    /*private void OnTriggerEnter(Collider other)
    {
        //relative to LEFTHAND will take cloest point on bound to trigger postion 
        pointOfContact = HandCollider.ClosestPointOnBounds(transform.position);
    }

    //sets final point of contract when triggered is exited 
    private void OnTriggerExit(Collider other)
    {
        //relative to LEFTHAND will take cloest point on bound to trigger postion 
        pointOfContact = HandCollider.ClosestPointOnBounds(transform.position);
    }*/

    /*private void OnTriggerEnter(Collider other)
    {
       contactPoint = hand.transform.position;
    }*/

    private void OnTriggerStay(Collider other)
    {

        /* Make an empty list to hold contact points
        ContactPoint[] contacts = new ContactPoint[10];

        // Get the contact points for this collision
        int numContacts = collision.GetContacts(contacts);
        distance = Vector3.Distance(contacts[0], hand.transform.position);*/

        //while in the trigger will claculate the distance from intal contract point to current hand postion  

        if (distance < 0)
        {
            contactPoint = hand.transform.position;
            distance = Vector3.Distance(contactPoint, hand.transform.position);
            Debug.Log(distance);
        }


        if (distance > 0.1f && distance <0.11f)
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.red;
        }
        else if (distance > 0.11f && distance < 0.12f)
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.yellow;
        }else if (distance > 0.12f && distance < 0.13f)
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.green;
        }
        else
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.white;
        }
    }

}



