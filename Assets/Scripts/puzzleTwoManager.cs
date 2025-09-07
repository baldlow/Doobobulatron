using UnityEngine;

public class puzzleTwoManager : MonoBehaviour
{
    public float timeLimit = 15f; // Time limit in seconds
    public bool allowReset = true; // puzzle will be invoked to reset, controller prevents invoke from happnening
    private float timer; // tracks time remaining
    public bool puzzleCompleted = false;
    private bool puzzleActive = false;
    private SwitchInteractable firstSwitch;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzleCompleted == true)
        {


        }
        else
        {

        
            if (puzzleActive)
            {
                timer -= Time.deltaTime;
                if (timer <= 0f)
                {
                    Debug.Log("Time's up! Puzzle failed.");
                    ResetPuzzle();
                }
            }
        }
    }
    void ResetPuzzle()
    {
        if (!allowReset)
        {
            Debug.Log("Reset not allowed for button 2.");
            puzzleCompleted = true;
            return;
        }
        puzzleActive = false;
        puzzleCompleted = false;
    }
    public void allPuzzlesComplete()
    {

        if (firstSwitch != null)
        {
            firstSwitch.allowReset = false;
            firstSwitch.setLeverState();
            firstSwitch.leverActive = true;
        }
    }
    public void SwitchPressed(SwitchInteractable switchLever)
    {
        if(!puzzleActive)
        {
            puzzleActive = true;
            puzzleCompleted = true;
            timer = timeLimit;
            firstSwitch = switchLever;
            Debug.Log("Puzzle 2 completed! third switch: " + switchLever.switchId);
        }

    }
}
