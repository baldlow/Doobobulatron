using UnityEngine;

public class LightController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Light sceneLight;
    public float timeBeforeOff = 5f;
    private bool isLightOn = true;

    void Start()
    {
        if(sceneLight == null)
            sceneLight = GetComponent<Light>();

        
        Invoke("TurnOffLight",timeBeforeOff);
    }

    public void TurnOffLight()
    {
        sceneLight.enabled = false;
        isLightOn = false;
        Debug.Log("The lights went out!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TurnOnLight()
    {

        sceneLight.enabled = true;
        isLightOn = true;
        Debug.Log("Lights restored");
    }
    public bool getLightStatus()
    {
        return isLightOn;
    }
}
