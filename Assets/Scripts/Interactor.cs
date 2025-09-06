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
    


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && grabbing.canUse)
        {
            Debug.Log("pressed E");

                if (grabbing.interactableObjectDetected.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                }
            
        }
    }
}
