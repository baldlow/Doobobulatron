using UnityEngine;

public class VentInteraction : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        //Runs when vent interacted :D
        Debug.Log("vent broken");
    }
}
