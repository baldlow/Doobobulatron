using UnityEngine;

public class VentInteraction : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        //Runs when vent interacted :D
        gameObject.SetActive(false);
        Debug.Log("vent broken");
    }
}
