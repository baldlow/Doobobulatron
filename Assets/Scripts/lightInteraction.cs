using UnityEngine;

public class LightInteractable : MonoBehaviour, IInteractable
{
    public LightController lightController;
    private int lightSwitchCounter;
    public void Interact()
    {
        //Runs when interacted :D
        lightSwitchCounter++;

        if (lightController != null){
            if (lightController.getLightStatus()){
                lightController.TurnOffLight();
            }else{
                lightController.TurnOnLight();
            }
        }else{
        Debug.Log("im null");
        }
        Debug.Log("IM A LightSwitch! x" + lightSwitchCounter);
    }
}
