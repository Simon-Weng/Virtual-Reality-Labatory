using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]

public class HandController : MonoBehaviour
{

    ActionBasedController controller;
    public Hand hand;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<ActionBasedController>(); //get the controller and puts it under the variable named "controller" 

    }

    // Update is called once per frame
    void Update()
    {
        //select = grip input 
        // action = trigger input 
        hand.SetGrip(controller.selectAction.action.ReadValue<float>());  // gets values for the grip input as a float value 
        hand.SetTrigger(controller.activateAction.action.ReadValue<float>()); // gets values for trigger input as a float values

        // the set trigger method and settrigger methods are detailed in the hands script 
        // pretty much the .setgrip or .settrigger method takes the the value of the 'controller.activateAction.action.readvalue  and returns a values 
        // in the hands script the value is then set as the target ie "triggertarget" and "griptarget" 
    }
}
