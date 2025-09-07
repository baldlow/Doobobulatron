using UnityEngine;

public class puzzleOneManager : MonoBehaviour
{
    public float timeLimit = 6f; // Time limit in seconds
    public bool allowReset = true; // puzzle will be invoked to reset, controller prevents invoke from happnening
    private float timer; // tracks time remaining
    public bool puzzleCompleted = false; // tracks if puzzle is completed
    private bool puzzleActive = false; // tracks that the puzzle has been started
    private SwitchInteractable firstSwitch;
    private SwitchInteractable secondSwitch;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
            //Debug.Log("Reset not allowed.");
            puzzleCompleted = true;
            return;
        }
        puzzleActive = false;
        puzzleCompleted = false;
        firstSwitch = null;
        secondSwitch = null;
    }
    
    public void allPuzzleComplete()
    {

        if(firstSwitch != null && secondSwitch != null)
        {
            firstSwitch.allowReset = false;
            secondSwitch.allowReset = false;
            firstSwitch.setLeverState();
            secondSwitch.setLeverState();
        }

    }
    public void SwitchPressed(SwitchInteractable switchLever)
    {
        if(!puzzleActive)
        {
            puzzleActive = true;
            timer = timeLimit;
            firstSwitch = switchLever;

            //Debug.Log("Puzzle started! First switch: " + switchLever.switchId);
        }
        else
        {
            if (switchLever != firstSwitch)
            {
                Debug.Log("Puzzle completed successfully!");
                puzzleCompleted = true;
                secondSwitch = switchLever;
                Invoke("ResetPuzzle", 4f);
            }
            else
            {
                Debug.Log("Same switch pressed again. Puzzle failed.");
                ResetPuzzle();
            }
        }

    }
}
