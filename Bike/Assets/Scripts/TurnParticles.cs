using UnityEngine;

public class TurnParticles : MonoBehaviour
{
    public float turnThreshold = 0.3f;
    public GameObject trailRendererParent;

    private TrailRenderer[] trailRenderers;
    private float turnTimer = 0.0f;

    private void Start()
    {
        // Get all the TrailRenderers in the parent GameObject
        trailRenderers = trailRendererParent.GetComponentsInChildren<TrailRenderer>();
    }

    private void Update()
    {
        // Check if A or D is being pressed
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            // Increase turn timer
            turnTimer += Time.deltaTime;

            // Check if turn timer is above threshold
            if (turnTimer > turnThreshold)
            {
                // Loop through all TrailRenderers and enable them
                foreach (TrailRenderer trailRenderer in trailRenderers)
                {
                    trailRenderer.emitting = true;
                }
            }
        }
        else
        {
            // Reset turn timer
            turnTimer = 0.0f;

            // Loop through all TrailRenderers and disable them
            foreach (TrailRenderer trailRenderer in trailRenderers)
            {
                trailRenderer.emitting = false;
            }
        }
    }
}
