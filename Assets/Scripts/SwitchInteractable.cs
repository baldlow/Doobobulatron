using UnityEngine;

public class SwitchInteractable : MonoBehaviour, IInteractable
{
    public puzzleOneManager puzzleManager;
    public string switchId;
    public void Interact()
    {

        if (puzzleManager != null){
            puzzleManager.SwitchPressed(switchId);
        }else{
        Debug.Log("im null");
        }
        Debug.Log("IM A switch! x" + switchId);
    }
}
