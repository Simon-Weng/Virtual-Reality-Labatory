using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class beam2 : MonoBehaviour
{

    Animator animator;

    private float triggerTarget;
    private float triggerCurrent;


    public float speed; // speed of how fast u want currentgrip --> target grip 

    public float ttt1; // Trigger Target decides which trigger box is which
    public float ttt2;
    public float ttv; // Trigger Value: the value that the trigger outputs 


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        ttt1 = 0;
        ttt2 = 0;
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

        animator.SetFloat("point1", ttt1);
        animator.SetFloat("point2", ttt2);

        /*if (triggerCurrent != triggerTarget)
        {
            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * speed);
            animator.SetFloat(animatorTriggerParam, triggerCurrent);
        }*/

    }
}

