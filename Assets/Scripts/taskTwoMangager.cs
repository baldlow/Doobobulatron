using UnityEngine;


public class taskTwoMangager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float timerDuration = 30f; // Time limit in seconds
    public bool allowReset = true; // puzzle will be invoked to reset, controller prevents invoke from happnening
    private bool timerRunning = false;
    private float timer; // tracks time remaining
    public bool puzzleCompleted = false; // tracks if puzzle is completed
    private bool puzzleActive = false; // tracks that the puzzle has been tarted
    public terminalInteractable terminalInteractable1;
    public terminalInteractable terminalInteractable2;
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
        terminalInteractable1.isActive = false;
        terminalInteractable2.isActive = false;
        terminalInteractable1 = null;
        terminalInteractable2 = null;
    }

    public void ActivateTerminalA()
    {
        if (!timerRunning)
        {
            timer = timerDuration;
            timerRunning = true;
        }else if (terminalInteractable2.isActive)
        {
            Debug.Log("Both terminals activated! Puzzle completed.");
            puzzleCompleted = true;
            timerRunning = false;
            terminalInteractable1 = null;
            terminalInteractable2 = null;
        }
    }
    public void ActivateTerminalB()
    {
        if (timerRunning)
        {
            terminalInteractable2.isActive = true;

        }
        else {             Debug.Log("Activate Terminal A first."); }
    }
    /*public void SwitchPressed(SwitchInteractable switchLever)
    {
        if (!puzzleActive)
        {
            puzzleActive = true;
            timer = timeLimit;
            terminalInteractable1 = switchLever;

            //Debug.Log("Puzzle started! First switch: " + switchLever.switchId);
        }
        else
        {
            if (switchLever != terminalInteractable1)
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

    }*/
}
