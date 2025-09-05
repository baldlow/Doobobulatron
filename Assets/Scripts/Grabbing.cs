using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Grabbing : MonoBehaviour
{
    public bool canGrab = false;
    public Image ui;

    void OnTriggerStay(Collider other)
    {
        Debug.Log("can grab");
        canGrab = true;
    }

    private void OnTriggerExit(Collider other)
    {
        canGrab = false;
    }

    private void Update()
    {
        ui.enabled = canGrab;
    }
}
