using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

//[RequrieComponet(typeof(ActionBaasedController))]

public class HandController : MonoBehaviour
{

    ActonBasedController controller;
    public Hand hand;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<ActionBasedController>();

    }

    // Update is called once per frame
    void Update()
    {
        //select = grip input 
        hand.SetGrip(controller.selectAction.action.ReadValue<float>());
        hand.SetTrigger(controller.activateAction.action.ReadValue<float>());
    }
}
