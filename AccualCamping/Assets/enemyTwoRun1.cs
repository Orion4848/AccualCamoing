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
        string currentAnimation = GetCurrentAnimation();

        if (currentAnimation == "Chase")
        {
            isRun = true;
            if (player != null)
            {

                Vector3 direction = (player.position - transform.position).normalized;

  
                Vector3 newPosition = transform.position;
                Vector3 desiredMovement = direction * moveSpeed * Time.deltaTime;

                
                newPosition += desiredMovement;
                rb.MovePosition(newPosition);
            }
        }
    }


    string GetCurrentAnimation()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

 
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
