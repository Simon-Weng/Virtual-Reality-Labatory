using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Animator))]

public class Beam : MonoBehaviour
{
    Animator animator;
   
    private float triggerTarget;
    private float triggerCurrent;
    private string animatorTriggerParam = "Trigger";

    public float speed; // speed of how fast u want currentgrip --> target grip 

    public float ttt; // Trigger Target decides which trigger box is which
    public float ttv; // Trigger Value: the value that the trigger outputs 


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        ttt = 0;
        ttv = 0;
    }

    // Update is called once per frame
    void Update()
    {
        AnimateBeam();
    }

    internal void SetTrigger(float v)
    {
        triggerTarget = v;
    }

    void AnimateBeam()
    {

        animator.SetFloat(animatorTriggerParam, ttt);

        /*if (triggerCurrent != triggerTarget)
        {
            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * speed);
            animator.SetFloat(animatorTriggerParam, triggerCurrent);
        }*/

    }
}
