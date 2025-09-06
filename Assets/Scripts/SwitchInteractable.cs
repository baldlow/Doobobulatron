using UnityEngine;

public class SwitchInteractable : MonoBehaviour, IInteractable
{

    public bool leverActive = false;
    public GameObject leverUpState = null;
    public GameObject leverDownState = null;
    public puzzleOneManager puzzleManager;
    public string switchId;

    public void Interact()
    {
        if(leverActive)
        {
            return;
        }
        else
        {
            leverActive = true;
            if (puzzleManager != null){
                puzzleManager.SwitchPressed(this);
            } else{
                Debug.Log("im null");
            }
        }

        leverUpState.SetActive(!leverActive);
        leverDownState.SetActive(leverActive);
        
    }

    void Start()
    {
        leverUpState.SetActive(!leverActive);
        leverDownState.SetActive(leverActive);
    }
    public void resetLever()
    {
        leverActive = false;
        leverUpState.SetActive(!leverActive);
        leverDownState.SetActive(leverActive);
    }
        //Debug.Log("IM A switch! x" + switchId);
}
