using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerHand : MonoBehaviour
{
    private float xpos;
    private float ypos;
    private float zpos;

    private Color m_oldcolor = Color.red;
  

    // Start is called before the first frame update
    void Start()
    {
        // gets postions of where the hands are initally 
        xpos = GameObject.Find("LeftHand").transform.position.x;
        ypos = GameObject.Find("LeftHand").transform.position.y;
        zpos = GameObject.Find("LeftHand").transform.position.z;

        Renderer render = GetComponent<Renderer>();
        render.material.color = m_oldcolor;
        
    }

    // Update is called once per frame
    void Update()
    {
        Renderer render = GetComponent<Renderer>();
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
                    render.material.color = Color.green;
                }
            }
        }
    }
}
