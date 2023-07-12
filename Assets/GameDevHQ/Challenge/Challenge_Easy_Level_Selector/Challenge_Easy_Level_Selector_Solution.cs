using UnityEngine;

public class Challenge_Easy_Level_Selector_Solution : MonoBehaviour
{
    private enum DIFFICULTY_LEVEL
    {
        EASY,
        MEDIUM,
        HARD
    }

    [SerializeField]
    private DIFFICULTY_LEVEL CurrentDifficultyLevel;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You selected " + CurrentDifficultyLevel);
        }
    }
}
