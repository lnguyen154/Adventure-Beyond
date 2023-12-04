using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    private Animator boxAnimator;

    private void Start()
    {
        // Find the child named "Box" and get the Animator component.
        Transform boxTransform = transform.Find("Box");

        if (boxTransform != null)
        {
            boxAnimator = boxTransform.GetComponent<Animator>();

            if (boxAnimator == null)
            {
                Debug.LogError("Animator component not found on the child Box GameObject.");
            }
        }
        else
        {
            Debug.LogError("Child GameObject named 'Box' not found.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the other collider belongs to the player GameObject.
        if (other.CompareTag("Player")) 
        {
            // Trigger the rotation animation in the Animator.
            if (boxAnimator != null)
            {
                boxAnimator.SetTrigger("TrigRotate");
            }
            else
            {
                Debug.LogError("Animator is null. Make sure the Animator component is assigned.");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (boxAnimator != null)
        {
            boxAnimator.SetTrigger("TrigStop");
        }
        else
        {
            Debug.LogError("Animator is null. Make sure the Animator component is assigned.");
        }
    }
}
