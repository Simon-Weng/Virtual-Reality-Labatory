using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class HandPresence : MonoBehaviour
{
    public InputDeviceCharacteristics controllerCharacteristics;
    public List<GameObject> controllerPrefabs;
    public GameObject handModelPrefab;
    public bool showController = false;

    private GameObject spawnedHandModel;
    private GameObject spawnedController;
    private InputDevice targetDevice;

    // Start is called before the first frame update
    void Start()
    {
        //creates new list  called devices 
        List<InputDevice> devices = new List<InputDevice>();



        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        // goes into each devives stored in list and logs in console name and charatist 
        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }
        //making sure it chooses thhe first devices 
        if (devices.Count > 0)
        {
            targetDevice = devices[0];

            //so the vraible prefab is given the name of the traget device through this fucntin that i hav eno idea how it works
            GameObject prefab = controllerPrefabs.Find(controller => controller.name == targetDevice.name);
            // spawns in controller using the prefab varaibel which holds our controller name 
            spawnedController = Instantiate(prefab, transform);

        }
        else
        {
            Debug.Log("did not find corresponding controllers");
            spawnedController = Instantiate(controllerPrefabs[0], transform);

        }
        
        spawnedHandModel = Instantiate(handModelPrefab, transform);


    }

    // Update is called once per frame
    void Update()
    {

        //i think this function gives out the value of the feature or button being pressured and inputs it into the "primarybuttonvalue" variable 
        //this checks if primary button is bing pressed if so it will long in the console "pressing priamry button"
        /*

        if (targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue)
        {
            Debug.Log("pressing primary button");
        }
        //the following code is similar however

        if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && triggerValue > 0.1f)
        {
            Debug.Log("pressing trigger" + triggerValue);
        }
        // this one is bugged and i have no idea why its confusing me 
        // idk why adding the unity XR thing worked but it did so its not bugged any more lmao damn

        if (targetDevice.TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue) && primary2DAxisValue != Vector2.zero)
        {
            Debug.Log("pressing trigger" + triggerValue);
        }
        */

        if (showController)
        {
            spawnedHandModel.SetActive(false);
            spawnedController.SetActive(true);

        }
        else
        {
            spawnedHandModel.SetActive(true);
            spawnedController.SetActive(false);
        }


    }
}