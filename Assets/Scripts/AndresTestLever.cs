using UnityEngine;

public class AndresTestLever : MonoBehaviour, IInteractable
{
    public bool leverActive = false;
    public GameObject leverUpState = null;
    public GameObject leverDownState = null;


    public void Interact()
    {
        if(leverActive)
        {
            leverActive = false;
        }
        else
        {
            leverActive= true;
        }

        leverUpState.SetActive(!leverActive);
        leverDownState.SetActive(leverActive);
        
    }

    void Start()
    {
        leverUpState.SetActive(!leverActive);
        leverDownState.SetActive(leverActive);
    }
}
