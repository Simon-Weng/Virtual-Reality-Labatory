using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger2_4 : MonoBehaviour
{
    public GameObject Beam2; //this is where the beam is stored as a game object 
    public beam2 beamScript; //declears script veraible as class Beam 
    //private BeamController scriptTest;

    public GameObject bmd3; // bmd for the trigger
    public bmd3 bmd3Script; // script for bmd

    // Start is called before the first frame update
    void Start()
    {
        beamScript = Beam2.GetComponent<beam2>();
        bmd3Script = bmd3.GetComponent<bmd3>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {

        
        beamScript.ttt1 = 0.8f;
        bmd3Script.ttt1 = 0.8f;


    }

    public void OnTriggerExit(Collider other)
    {

        
        beamScript.ttt1 = 0.0f;
        bmd3Script.ttt1 = 0.0f;

    }

}
