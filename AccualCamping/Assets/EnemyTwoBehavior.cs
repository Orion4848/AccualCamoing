using System.Collections;
using UnityEngine;

public class EnemyTwoBehavior : MonoBehaviour
{
    public GameObject looker;
    Animator animator;
    float x = 0f; 

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // if (other.gameObject == looker)
        //{
        animator.SetBool("lookedAt", true);
        StartCoroutine(IncrementX());
        //    }
    }

    private void OnTriggerExit(Collider other)
    {
        if (animator.GetFloat("lookTime") > 99)
        {
            animator.SetFloat("lookTime", 0);
        }
        animator.SetBool("lookedAt", false);
    }

    IEnumerator IncrementX()
    {
        while (animator.GetFloat("lookTime") < 5 && animator.GetBool("lookedAt") == true)
        {
            yield return new WaitForSeconds(0.02f); 
            x += 0.1f; 
            animator.SetFloat("lookTime", x);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
