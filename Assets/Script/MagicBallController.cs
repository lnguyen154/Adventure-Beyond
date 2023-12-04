
using UnityEngine;

public class MagicBallController : MonoBehaviour
{
    public ParticleSystem electricBeam;
    public ParticleSystem circle;
    public ParticleSystem smoke;
    public ParticleSystem particle;

    public AudioClip magicSound;

    // Boolean flag to track whether the collision has occurred
    private bool hasCollided = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasCollided)
        {
            // Check if the particle system is assigned
            if (electricBeam && circle && smoke && particle != null)
            {
                // Play the particle system
                electricBeam.Play();
                circle.Play();
                smoke.Play(); 
                particle.Play();
                
            }

            // Check if an audio clip is assigned
            if (magicSound != null)
            {
                // Play the sound
                AudioSource.PlayClipAtPoint(magicSound, transform.position);
            }

            // Set the flag to true to indicate that the collision has occurred
            hasCollided = true;

        }
    }
}
