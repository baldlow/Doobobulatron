using UnityEngine;

public class TestInteraction : MonoBehaviour, IInteractable
{
    private int imABalLCounter;
    public void Interact()
    {
        //Runs when interacted :D
        imABalLCounter++;
        Debug.Log("IM A BALL! x" + imABalLCounter);
    }
}
