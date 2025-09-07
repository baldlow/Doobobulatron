using UnityEngine;

public class HallwayTrigger : MonoBehaviour
{
    public GameObject enableThis = null;
    public GameObject disableThis = null;
    [SerializeField]
    private bool hasBeenTriggered = false;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8 && !hasBeenTriggered)
        {
            Debug.Log("I HATE FAMILY WEEKEND AAAGGGHHHHHH!!!");

            if (enableThis != null)
            {
                enableThis.SetActive(true);
            }

            if (disableThis != null)
            {
                disableThis.SetActive(false);
            }
            hasBeenTriggered = true;
        }
    }
}
