using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TT2 : MonoBehaviour
{
    //load up the lefthand 
    public Transform hand;
    //creates a variable for the trigger of the object 
    private Collider triggerCollider;
    //creates the variable for activation 
    private float activation;
    //creates variable for distance 
    private float dist = 0;
    //creates variable for cloestpoint
    private Vector3 cPoint;
  

    //test using object 
    public Transform test;


    // Start is called before the first frame update
    void Start()
    {
        //get collider from of object 
        triggerCollider = GetComponent<Collider>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
        /*if (activation == 2)
        {
            float dist = Vector3.Distance(cPoint, hand.position);
            if (dist >= 0.5)
            {
                Renderer render = GetComponent<Renderer>();
                render.material.color = Color.red;
            }
            else
            {
                Renderer render = GetComponent<Renderer>();
                render.material.color = Color.white;
            }
        }*/



    }

    public void OnTriggerEnter(Collider other)
    {
        //tells the update function that the trigger has been acitvated 
        activation = 2;
        //gets the intial cpoint 
        cPoint = triggerCollider.ClosestPoint(hand.position);


    }

    public void OnTriggerExit(Collider other)
    {
        //tells the update function that the trigger has been acitvated 
        activation = 1;
        dist = 0;

        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.white;

    }

   public void OnTriggerStay(Collider other)
    {
        float dist = Vector3.Distance(cPoint, hand.position);

        if (dist >= 1)
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.red;
        }
        else
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.white;
        }
    }






}


//debug log 1 : for some reason its getting the inputs for the ontrii