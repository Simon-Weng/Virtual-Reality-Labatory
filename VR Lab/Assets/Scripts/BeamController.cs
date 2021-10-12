using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]

public class BeamController : MonoBehaviour
{

    ActionBasedController controller;
    public Beam beam;

    public float ttt; // Trigger Target decides which trigger box is which
    public float ttv; // Trigger Value: the value that the trigger outputs 

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<ActionBasedController>(); //get the controller and puts it under the variable named "controller" 
        ttt = 0;
        ttv = 0;
    }

    // Update is called once per frame
    void Update()
    {


        ttt = 0.8f;
     
        beam.SetTrigger(ttt);
       

        //select = grip input 
        // action = trigger input 

        beam.SetTrigger(controller.activateAction.action.ReadValue<float>());

        // the set trigger method and settrigger methods are detailed in the hands script 
        // pretty much the .setgrip or .settrigger method takes the the value of the 'controller.activateAction.action.readvalue  and returns a values 
        // in the hands script the value is then set as the target ie "triggertarget" and "griptarget" 
    }
}
