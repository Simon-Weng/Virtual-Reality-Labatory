/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{

    private float check;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //depending on ouput value of the method SetColor it will change the color of the cube either green for actived or white for nothing 
        if (check > 0)
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.green;
        } else {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.white;
        }
    }

    //creates this method called "SetColor" which when condtions are meet in CubeController will take the outputed value
    internal void SetTestColor(float v)
    {
        check = v;

    }

   

}*/
