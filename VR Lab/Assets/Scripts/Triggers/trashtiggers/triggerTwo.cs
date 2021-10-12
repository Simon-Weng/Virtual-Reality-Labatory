using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerTwo : MonoBehaviour
{
    public GameObject Beam1; //this is where the beam is stored as a game object 
    public Beam beamScript; //declears script veraible as class Beam 
                            //private BeamController scriptTest;


    // Start is called before the first frame update
    void Start()
    {
        beamScript = Beam1.GetComponent<Beam>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {

        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.red;
        beamScript.ttt = 0.4f;


    }

    public void OnTriggerExit(Collider other)
    {

        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.white;
        beamScript.ttt = 0.0f;

    }
}
