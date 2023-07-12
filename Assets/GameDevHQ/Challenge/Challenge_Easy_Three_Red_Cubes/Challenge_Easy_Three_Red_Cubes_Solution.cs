using UnityEngine;

public class Challenge_Easy_Three_Red_Cubes_Solution : MonoBehaviour
{

    [SerializeField] 
    private MeshRenderer[] ThreeRedCubesArray;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (MeshRenderer meshRenderer in ThreeRedCubesArray)
            {
                meshRenderer.material.color = Color.red;
            }
        }
    }
}
