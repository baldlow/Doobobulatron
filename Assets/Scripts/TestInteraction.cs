using UnityEngine;

public class TestInteraction : MonoBehaviour, IInteractable
{
    private int imABalLCounter;
    [SerializeField] private AudioClip boingSoundClip;
    public void Interact()
    {
        //Runs when interacted :D
        imABalLCounter++;
        Debug.Log("IM A BALL! x" + imABalLCounter);

        // play sound FX
        SoundFXManager.instance.PlaySoundFXClip(boingSoundClip, transform, 1f);
        Debug.Log("Allegedly played sound FX");
    }
}
