using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bmd4 : MonoBehaviour
{
    Animator animator;

    public float speed; // speed of how fast u want currentgrip --> target grip 

    public float ttt1; // Trigger Target decides which trigger box is which




    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        ttt1 = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {
        AnimateBeam();
    }

    void AnimateBeam()
    {

        animator.SetFloat("point4", ttt1);


        /*if (triggerCurrent != triggerTarget)
        {
            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * speed);
            animator.SetFloat(animatorTriggerParam, triggerCurrent);
        }*/

    }
}
