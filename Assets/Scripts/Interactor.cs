using UnityEngine;

interface IInteractable
{
    public void Interact();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float interactRange = 5f;
    public Grabbing grabbing;
    
    void Update()
    {
        // If presssing E and the grabbing script detects a usable object
        if (Input.GetKeyDown(KeyCode.E) && grabbing.canUse)
        {
            Debug.Log("pressed E");

            // Checks if the object selected has a script that is interactable
                if (grabbing.interactableObjectDetected.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }
            
        }
    }
}
