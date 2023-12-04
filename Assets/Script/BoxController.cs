using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{

    private Animator death;

    public Transform respawnPoint;

    private void Start()
    {
        death = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            StartCoroutine(RespawnPlayerAfterAnimation());
        }
    }

    private IEnumerator RespawnPlayerAfterAnimation()
    {
        if (death != null)
        {
            death.SetTrigger("Death");

            // Wait for the animation to finish (adjust the time accordingly)
            yield return new WaitForSeconds(2.0f);


            death.SetTrigger("Respawn");
        }

        else
        {
            Debug.LogError("Animator is null. Make sure the Animator component is assigned.");

        }
            // Check if the respawnPoint is assigned before using it
            if (respawnPoint != null)
        {
            // Reset player position to respawn point
            transform.position = respawnPoint.position;
        }
        else
        {
            // Log a warning if respawnPoint is not assigned
            Debug.LogWarning("Respawn point not assigned!");
        }
    }
}
