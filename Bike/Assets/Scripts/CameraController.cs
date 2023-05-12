using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // The target the camera should follow
    public float distance = 10.0f; // The distance between the camera and the target
    public float height = 5.0f; // The height offset between the camera and the target
    public float rotationDamping = 10.0f; // The speed at which the camera should rotate

    void LateUpdate()
    {
        // Calculate the target position based on the distance and height offsets
        Vector3 targetPosition = target.position - target.forward * distance + Vector3.up * height;

        // Smoothly move the camera towards the target position
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * rotationDamping);

        // Calculate the target rotation to face the same direction as the target object
        Quaternion targetRotation = Quaternion.LookRotation(target.forward, Vector3.up);

        // Smoothly rotate the camera towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationDamping);
    }
}