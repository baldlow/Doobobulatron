using UnityEngine;

public class puzzleOneManager : MonoBehaviour
{
    public float timeLimit = 6f; // Time limit in seconds
    private float timer;
    private bool puzzleActive = false;
    public string firstLightSwitch;
    private SwitchInteractable firstSwitch;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzleActive)
        {
            timer -= Time.deltaTime;
            if(timer <= 0f)
            {
                Debug.Log("Time's up! Puzzle failed.");
                ResetPuzzle();
            }
        }
        
    }
    void ResetPuzzle()
    {
        puzzleActive = false;
        firstLightSwitch = null;
        foreach(var switchObj in FindObjectsOfType<SwitchInteractable>())
        {
            switchObj.resetLever();
        }
    }
    public void SwitchPressed(SwitchInteractable switchLever)
    {
        if(!puzzleActive)
        {
            puzzleActive = true;
            timer = timeLimit;
            /*firstLightSwitch = switchId;*/
            firstSwitch = switchLever;

            Debug.Log("Puzzle started! First switch: " + switchLever.switchId);
        }
        else
        {
            if (switchLever != firstSwitch)
            {
                Debug.Log("Puzzle completed successfully!");
                ResetPuzzle();
            }
            else
            {
                Debug.Log("Same switch pressed again. Puzzle failed.");
                ResetPuzzle();
            }
        }

    }
}
