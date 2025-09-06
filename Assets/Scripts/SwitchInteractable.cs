using UnityEngine;

public class SwitchInteractable : MonoBehaviour, IInteractable
{

    public bool leverActive = false;
    public bool allowReset = true;
    public float activatDuration = 3f;
    public float buttonResetDuration = 10f;
    public GameObject leverUpState = null;
    public GameObject leverDownState = null;
    public puzzleOneManager puzzleManager;
    public puzzleTwoManager puzzle2Manager;
    public string switchId;

    public void Interact()
    {
        if (leverActive)
        {
            return;
        }
        else
        {
            leverActive = true;
            if (puzzleManager != null) {
                puzzleManager.SwitchPressed(this);
            } else if (puzzle2Manager != null) {
                puzzle2Manager.SwitchPressed(this);
            }
            else {
                Debug.Log("im null");
            }
        }

        leverUpState.SetActive(!leverActive);
        leverDownState.SetActive(leverActive);
        if (puzzle2Manager != null)
        {
            Invoke("resetLever", buttonResetDuration);
        }
        else
        {
            Invoke("resetLever", activatDuration);

        }

    }

    void Start()
    {
        leverUpState.SetActive(!leverActive);
        leverDownState.SetActive(leverActive);
    }
    public void resetLever()
    {
        if (!allowReset)
        {
            return;
        }
        leverActive = false;
        leverUpState.SetActive(!leverActive);
        leverDownState.SetActive(leverActive);

    }
    public void setLeverState()
    {
        leverActive = true;
        leverUpState.SetActive(!leverActive);
        leverDownState.SetActive(leverActive);
    }
        //Debug.Log("IM A switch! x" + switchId);
}
