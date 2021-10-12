using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger33 : MonoBehaviour
{
    public GameObject Beam2; //this is where the beam is stored as a game object 
    public beam2 beamScript; //declears script veraible as class Beam 
    //private BeamController scriptTest;

    public GameObject bmd4; // bmd for the trigger
    public bmd4 bmd4Script; // script for bmd 

    // Start is called before the first frame update
    void Start()
    {
        beamScript = Beam2.GetComponent<beam2>();
        bmd4Script = bmd4.GetComponent<bmd4>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {

        
        beamScript.ttt2 = 0.6f;
        bmd4Script.ttt1 = 0.6f;


    }

    public void OnTriggerExit(Collider other)
    {

       
        beamScript.ttt2 = 0.0f;
        bmd4Script.ttt1 = 0.0f;

    }
}
