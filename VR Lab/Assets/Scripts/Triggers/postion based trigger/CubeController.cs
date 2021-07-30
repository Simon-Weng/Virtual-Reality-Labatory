using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
   
    private float xpos;
    private float ypos;
    private float zpos;

    private float v;

    public Beam beam;

    // Start is called before the first frame update
    void Start()
    {
        // gets postions of where the hands are initally 
        xpos = GameObject.Find("LeftHand").transform.position.x;
        ypos = GameObject.Find("LeftHand").transform.position.y;
        zpos = GameObject.Find("LeftHand").transform.position.z;



    }

    // Update is called once per frame
    void Update()
    {
       
        //updates positons of hands 
        xpos = GameObject.Find("LeftHand").transform.position.x;
        ypos = GameObject.Find("LeftHand").transform.position.y;
        zpos = GameObject.Find("LeftHand").transform.position.z;

        //if the postion is within the paramtere animation should be activted 
        if (xpos < 0.2 + 0.5 && xpos < 0.2 - 0.5)
        {
            if (zpos < -4 + 0.2 && zpos > -4 - 0.2)
            {
                if (ypos < 1.5)
                {
                    v = 1.5f - ypos;
                    beam.SetTrigger(v);
                }
            }
        }
        else
        {
            v = 0f;
            beam.SetTrigger(v);
        }
    }
}


