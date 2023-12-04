using UnityEngine;

public class SpotlightController : MonoBehaviour
{
    public Light spotlight;  // Drag your spotlight GameObject here in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (spotlight.enabled == true)
            {
                // Player touched the tower, turn off the spotlight
                TurnOffSpotlight();
            }
            else 
            {
                TurnOnSpotlight();
            }
        }
    }

    private void TurnOnSpotlight()
    {
        // Activate the spotlight or set its intensity to a non-zero value
        spotlight.enabled = true;
    }

    private void TurnOffSpotlight()
    {
        // Deactivate the spotlight or set its intensity to zero
        spotlight.enabled = false;
    }
}
