using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyTwoRun : MonoBehaviour
{
    public Transform player; 
    public float moveSpeed = 5f; 
    public LayerMask obstacleLayer; 
    public bool isRun = false;
    public float raycastHeight;

    private Rigidbody rb;


    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }




    void Update()
    {
        // Check the current animation and perform actions accordingly
        string currentAnimation = GetCurrentAnimation();

        if (currentAnimation == "Chase")
        {
            isRun = true;
            if (player != null)
            {
                // Calculate the direction from the enemy to the player
                Vector3 direction = (player.position - transform.position).normalized;

                // Preserve the y-coordinate of the enemy's position
                Vector3 newPosition = transform.position;

                // Cast a ray from a point slightly above the enemy towards the player

                // Calculate the desired movement based on moveSpeed and deltaTime
                Vector3 desiredMovement = direction * moveSpeed * Time.deltaTime;

                // Apply the movement while preserving the y-coordinate
                newPosition += desiredMovement;
                rb.MovePosition(newPosition);
            }
        }
    }









    string GetCurrentAnimation()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // Check if the current animation state matches any of the known states
        if (stateInfo.IsName("Base Layer.Idle"))
        {
            return "Idle";
        }
        else if (stateInfo.IsName("Base Layer.Chase"))
        {
            return "Chase";
        }
        else
        {
            return "Unknown";
        }
    }
}
