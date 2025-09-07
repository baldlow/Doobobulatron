using UnityEngine;

// To use this script, make sure the GameObject has an AudioSource component
//  and assign an audio clip to it in the Inspector.
public class TestInteractionWithAudio : MonoBehaviour, IInteractable
{
    // Reference to the AudioSource component;
    // can add more if there is more than 1
    // sound effect =)
    private AudioSource audioSource0;

    private int imABalLCounter;
    public void Interact()
    {
        //Runs when interacted :D
        imABalLCounter++;
        Debug.Log("IM A BALL! x" + imABalLCounter);

        // Play sound effect when interacted
        PlaySoundEffect();
    }

    public void PlaySoundEffect()
    {
        // GetComponent<AudioSource>() is a method that retrieves a reference to
        //  the AudioSource component attached to the same GameObject as the script
        //  executing the method.

        // Get the AudioSource component if not assigned in the Inspector
        if (audioSource0 == null)
        {
            audioSource0 = GetComponent<AudioSource>();
            Debug.Log("AudioSource component assigned via GetComponent.");
        }

        // Play the sound effect if the AudioSource component is found
        if (audioSource0 != null)
        {
            audioSource0.Play();
            Debug.Log("Playing sound effect.");
        }
        else
        {
            Debug.LogWarning("No AudioSource component found on this GameObject.");
        }
    }
}
