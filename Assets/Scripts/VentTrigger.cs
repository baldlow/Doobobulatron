using UnityEngine;

public class VentTrigger : MonoBehaviour
{

    public GameObject interactable_vent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            interactable_vent.layer = 7;
        }
    }
    void Update()
    {
        
    }
}
