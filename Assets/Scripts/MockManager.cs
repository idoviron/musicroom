using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MockManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Is device active: " + XRSettings.isDeviceActive);
        Debug.Log("Device name is: " + XRSettings.loadedDeviceName);

        if (XRSettings.isDeviceActive && XRSettings.loadedDeviceName.Contains("MockHMD"))
        {
            Debug.Log("Using Mock HMD");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
