using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour
{
    private Light myLight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
