using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VROff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SetVRDevice("none"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SetVRDevice(string device)
    {
        XRSettings.LoadDeviceByName(device);
        yield return null;
        XRSettings.enabled = true;
    }
}
