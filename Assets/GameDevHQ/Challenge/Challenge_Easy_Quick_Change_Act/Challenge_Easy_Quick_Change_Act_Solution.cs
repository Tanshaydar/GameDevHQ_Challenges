using UnityEngine;

/**
 * This solution does not use RigidBody and OnCollision / OnTrigger functions.
 * This solution instead utilizes if there was an intersection between the objects via Intersects method.
 * Movement is handled with FixedUpdate to comply with Physics update.
 * There are no additional materials used, default material is used.
 */
public class Challenge_Easy_Quick_Change_Act_Solution : MonoBehaviour
{
    [Header("This is the wall object that needs its color changed.")]
    public MeshRenderer ColorChangeWall;
    
    private float horizontalInput;
    private float verticalInput;
    private MeshRenderer _meshRenderer;

    private bool WasInside = false;
    
    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        
            if (ColorChangeWall.bounds.Intersects(_meshRenderer.bounds))
            {
                WasInside = true;
            }
            else
            {
                if (WasInside)
                {
                    ChangeColorOfTheWall();
                }
                WasInside = false;
            }
    }

    private void FixedUpdate()
    {
        transform.Translate(horizontalInput, 0f, 0f);
    }

    private void ChangeColorOfTheWall()
    {
        ColorChangeWall.material.color = Random.ColorHSV();
    }

}
