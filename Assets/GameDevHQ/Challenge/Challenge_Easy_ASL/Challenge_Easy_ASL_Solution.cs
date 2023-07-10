using System.Text;
using UnityEngine;

public class Challenge_Easy_ASL_Solution : MonoBehaviour
{

    [SerializeField][Range(0,100)]
    private int Age;
    [SerializeField]
    private string Sex;
    [SerializeField]
    private string Location;

    private string OutPut;

    private void Awake()
    {
        OutPut = new StringBuilder(Age + " " + Sex + " " + Location).ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(OutPut);
        }
    }
}
