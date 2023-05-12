using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOUNDCAR : MonoBehaviour
{
    [SerializeField] AudioSource carSound;
    [SerializeField] float pitchIncreaseSpeed = 0.1f;
    [SerializeField] float pitchDecreaseSpeed = 0.1f;
    [SerializeField] float maxPitch = 3f;
    [SerializeField] float maxPitchRandomness = 0.2f;
    [SerializeField] float idlePitch = 0.9f;

    float currentPitch = 0.9f;
    float targetPitch = 0.9f;

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Vertical");

        if (moveInput > 0)
        {
            targetPitch = maxPitch + Random.Range(-maxPitchRandomness, maxPitchRandomness);
        }
        else
        {
            targetPitch = idlePitch;
        }

        if (currentPitch != targetPitch)
        {
            if (moveInput > 0)
            {
                currentPitch = Mathf.MoveTowards(currentPitch, targetPitch, pitchIncreaseSpeed * Time.deltaTime);
            }
            else
            {
                currentPitch = Mathf.MoveTowards(currentPitch, targetPitch, pitchDecreaseSpeed * Time.deltaTime);
            }
            carSound.pitch = currentPitch;
        }
    }

}