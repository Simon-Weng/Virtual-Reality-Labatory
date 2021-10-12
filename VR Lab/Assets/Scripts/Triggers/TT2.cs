using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TT2 : MonoBehaviour
{
   
    public Transform hand;  //load up the lefthand 
    private Collider triggerCollider;  //creates a variable for the trigger of the object 

    private float dist; //creates variable for distance 
    private Vector3 cPoint;//creates variable for cloestpoint

    public GameObject Beam1; //this is where the beam is stored as a game object 
    private Beam beamScript; //declears script veraible as class Beam 
    private BeamController ScriptTest;


    public Transform prefab;

    // Start is called before the first frame update
    void Start()
    {
        //get collider from of object 
        triggerCollider = GetComponent<Collider>();
        //scriptTest = Beam1.GetComponent<BeamController>();
        // beamScript = Beam1.GetComponent<Beam>(); //this gets the BEAM script fromt he object BEAM1
        dist = 0f;


    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void OnTriggerEnter(Collider other)
    {
        cPoint = triggerCollider.ClosestPoint(hand.position);
        dist = 0;

        Instantiate(prefab, cPoint, Quaternion.identity);

        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.blue;

       
    }

    public void OnTriggerExit(Collider other)
    {
        
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.white;

        cPoint = triggerCollider.ClosestPoint(hand.position);
        dist = 0;
    }

    public void OnTriggerStay(Collider other)
    {

        float dist = Vector3.Distance(cPoint, hand.position);
      
     
        if (dist > 0.1f && dist < 0.3f )
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.red;

        }else if( dist > 0.3f && dist < 0.5f)
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.yellow;
        }
        else if(dist > 0.5f && dist < 0.7f)
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.green;
        }
      

    }

       
     


}


//debug log 1 : for some reason its getting the inputs for the ontrii